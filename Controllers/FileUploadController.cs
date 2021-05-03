using System;
using System.IO;
using System.Text.RegularExpressions;
using BackEnd.Entities;
using BackEnd.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class FileUploadController : BaseController
    {
        [HttpPost]
        public ActionResult<FileModel> UploadFile([FromForm] FileModel file)
        {
            try
            {
                var uniqueFileName = GetUniqueFileName(file.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Resources", uniqueFileName);
                System.Diagnostics.Debug.WriteLine(file.FileName.ToString());
                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    file.FormFile.CopyTo(stream);
                }
                var fileUploaded = new FileModel();
                fileUploaded.FileName = uniqueFileName;
                return StatusCode(StatusCodes.Status201Created, fileUploaded);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            var fileNameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
            var extension = Path.GetExtension(fileName);
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileNameWithoutExt = rgx.Replace(fileName, "");
            fileNameWithoutExt = fileName.Replace(' ', '_');
            var uniqueId = Guid.NewGuid().ToString().Substring(0, 4);
            return fileNameWithoutExt + "_" + uniqueId + "_" + Timestamp + extension;
        }

    }
}