using Buoi8_Use_DatabaseFirst.Models;
using Buoi8_Use_DatabaseFirst.Services;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Diagnostics;
using System.IO;
using WebTransaction.Helper;
using WebTransaction.Models;

namespace Buoi8_Use_DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db;
        private ICarInService carinService;
        private IWebHostEnvironment webHostEnvironment;

        public HomeController(ICarInService _carInService, IWebHostEnvironment _webHostEnvironment, DatabaseContext _db)
        {
            db = _db;
            carinService = _carInService;
            webHostEnvironment = _webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new AcsTransactionCarIn());
        }

        [Route("index")]
        [HttpPost]
        public IActionResult Index(AcsTransactionCarIn carin, IFormFile file, IFormFile filePlate)
        {
            bool IsDeleted = true;

            if(IsDeleted)
            {
                carin.IsDeleted = true;
            }
            else
            {
                carin.IsDeleted = false;
            }

            if(file != null && filePlate != null)
            {
                string fileName = "CI" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + carin.LaneId;
                string uploadFilePath = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileName + ".jpg");
                using (var fileStream = new FileStream(uploadFilePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);

                }

                string fileNamePlate = "CI" + DateTime.Now.ToString("yyyyMMddHhmmss") + "_" + carin.Plate;
                string uploadFilePathPlate = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileNamePlate + ".jpg");
                using (var fileStreamPlate = new FileStream(uploadFilePathPlate, FileMode.Create))
                {
                    filePlate.CopyTo(fileStreamPlate);
                }
            }
            

            //var uploadFile = Path.Combine(rootPath, "ImagesForDevice");
            //if(file != null)
            //{
            //    string fileName = Path.GetFileNameWithoutExtension(DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + carin.LaneId);
            //    string extension = Path.GetExtension(file.FileName);
            //    fileName = fileName + extension;
            //    using (var fileStream = new FileStream(Path.Combine(Path.Combine(rootPath, "ImagesForDevice"), fileName), FileMode.Create))
            //    {
            //        file.CopyTo(fileStream);
            //    }
            //}

            var carIn = new AcsTransactionCarIn
            {
                Id = carin.Id,
                CardId = carin.CardId,
                TransactionDate = carin.TransactionDate,
                CardTypeId = carin.CardTypeId,
                VehicleTypeId = carin.VehicleTypeId,
                UserId = carin.UserId,
                ShiftId = carin.ShiftId,
                LaneId = carin.LaneId,
                StationId = carin.StationId,
                Plate = carin.Plate,
                LaneImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + carin.LaneId,
                PlateImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + carin.Plate,
                Note = carin.Note,
                ProcessDate = carin.ProcessDate,
                PartnerId = carin.PartnerId,
                F0 = carin.F0,
                F1 = carin.F1,
                F2 = carin.F2,
                F3 = carin.F3,
                PlateHk = carin.PlateHk,
                PlateO = carin.PlateO,
                Code = carin.Code,
                CreateUid = carin.CreateUid,
                CreateDate = DateTime.Now,
                WriteUid = carin.WriteUid,
                WriteDate = DateTime.Now,

            };

           carinService.CreateCarIn(carIn);
           return RedirectToAction("privacy");
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [Route("pageCarOut")]
        public IActionResult PageCarOut()
        {
            return View(new AcsTransactionCarOut());
        }

        [HttpPost]
        [Route("pageCarOut")]
        public IActionResult PageCarOut(AcsTransactionCarOut carout, IFormFile file, IFormFile filePlate)
        {
            if (file != null && filePlate != null)
            {
                string fileName = "CO" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + carout.LaneId;
                string uploadFilePath = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileName + ".jpg");
                using (var fileStream = new FileStream(uploadFilePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);

                }

                string fileNamePlate = "CO" + DateTime.Now.ToString("yyyyMMddHhmmss") + "_" + carout.Plate;
                string uploadFilePathPlate = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileNamePlate + ".jpg");
                using (var fileStreamPlate = new FileStream(uploadFilePathPlate, FileMode.Create))
                {
                    filePlate.CopyTo(fileStreamPlate);
                }
            }

            var carOut = new AcsTransactionCarOut
            {
                Id = carout.Id,
                CardId = carout.CardId,
                TransactionDate = carout.TransactionDate,
                CardTypeId = carout.CardTypeId,
                VehicleTypeId = carout.VehicleTypeId,
                UserId = carout.UserId,
                ShiftId = carout.ShiftId,
                LaneId = carout.LaneId,
                StationId = carout.StationId,
                Plate = carout.Plate,
                LaneImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + carout.LaneId,
                PlateImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + carout.Plate,
                Note = carout.Note,
                ProcessDate = carout.ProcessDate,
                PartnerId = carout.PartnerId,
                TransactionIdIn = carout.TransactionIdIn,
                StationIdIn = carout.StationIdIn,
                LaneIdIn = carout.LaneIdIn,
                TransactionDateIn = carout.TransactionDateIn,
                Price = carout.Price,
                Total = carout.Total,
                Minutes = carout.Minutes,
                Barcode = carout.Barcode,
                SerialNo = carout.SerialNo,
                InvoiceNo = carout.InvoiceNo,
                FormNo = carout.FormNo,
                Serial = carout.Serial,
                F0 = carout.F0,
                F1 = carout.F1,
                F2 = carout.F2,
                F3 = carout.F3,
                PlateHk = carout.PlateHk,
                PlateO = carout.PlateO,
                Code = carout.Code,
                CreateUid = carout.CreateUid,
                WriteUid = carout.WriteUid
            };

            carinService.CreateCarOut(carOut);
            return View("privacy");
        }

        [HttpGet]
        [Route("pageMotorIn")]
        public IActionResult PageMotorIn()
        {
            return View(new AcsTransactionMotorIn());
        }

        [HttpPost]
        [Route("pageMotorIn")]
        public IActionResult PageMotorIn(AcsTransactionMotorIn motorin, IFormFile file, IFormFile filePlate)
        {
            bool IsDeleted = true;
            if(IsDeleted)
            {
                motorin.IsDeleted = true;
            }
            else
            {
                motorin.IsDeleted = false;
            }

            if(file != null && filePlate != null)
            {
                string fileName = "MI" + DateTime.Now.ToString("yymmssfff") + "_" + motorin.LaneId;
                string uploadFilePath = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileName + ".jpg");
                using (var fileStream = new FileStream(uploadFilePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);

                }

                string fileNamePlate = "MI" + DateTime.Now.ToString("yymmssfff") + "_" + motorin.Plate;
                string uploadFilePathPlate = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileNamePlate + ".jsp");
                using(var fileStreamPlate = new FileStream(uploadFilePathPlate, FileMode.Create))
                {
                    filePlate.CopyTo(fileStreamPlate);
                }
            }

            var motorIn = new AcsTransactionMotorIn
            {
                Id = motorin.Id,
                CardId = motorin.CardId,
                TransactionDate = motorin.TransactionDate,
                CardTypeId = motorin.CardTypeId,
                VehicleTypeId = motorin.VehicleTypeId,
                UserId = motorin.UserId,
                ShiftId = motorin.ShiftId,
                LaneId = motorin.LaneId,
                StationId = motorin.StationId,
                Plate = motorin.Plate,
                LaneImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + motorin.LaneId,
                PlateImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + motorin.Plate,
                Note = motorin.Note,
                ProcessDate = motorin.ProcessDate,
                PartnerId = motorin.PartnerId,
                F0 = motorin.F0,
                F1 = motorin.F1,
                F2 = motorin.F2,
                F3 = motorin.F3,
                PlateHk = motorin.PlateHk,
                PlateO = motorin.PlateO,
                Code = motorin.Code,
                CreateUid = motorin.CreateUid,
                CreateDate = DateTime.Now,
                WriteUid = motorin.WriteUid,
                WriteDate = DateTime.Now,

            };

            carinService.CreateMotorIn(motorIn);
            return View("privacy");
        }

        [HttpGet]
        [Route("pageMotorOut")]
        public IActionResult PageMotorOut()
        {
            return View(new AcsTransactionMotorOut());
        }

        [HttpPost]
        [Route("pageMotorOut")]
        public IActionResult PageMotorOut(AcsTransactionMotorOut motorout, IFormFile file, IFormFile filePlate)
        {
            if (file != null && filePlate != null)
            {
                string fileName = "MO" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + motorout.LaneId;
                string uploadFilePath = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileName + ".jpg");
                using (var fileStream = new FileStream(uploadFilePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);

                }

                string fileNamePlate = "MO" + DateTime.Now.ToString("yyyyMMddHhmmss") + "_" + motorout.Plate;
                string uploadFilePathPlate = Path.Combine(Directory.GetCurrentDirectory(), "\\UploadFiles", fileNamePlate + ".jpg");
                using (var fileStreamPlate = new FileStream(uploadFilePathPlate, FileMode.Create))
                {
                    filePlate.CopyTo(fileStreamPlate);
                }
            }

            var motorOut = new AcsTransactionMotorOut
            {
                Id = motorout.Id,
                CardId = motorout.CardId,
                TransactionDate = motorout.TransactionDate,
                CardTypeId = motorout.CardTypeId,
                VehicleTypeId = motorout.VehicleTypeId,
                UserId = motorout.UserId,
                ShiftId = motorout.ShiftId,
                LaneId = motorout.LaneId,
                StationId = motorout.StationId,
                Plate = motorout.Plate,
                LaneImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + motorout.LaneId,
                PlateImage = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + motorout.Plate,
                Note = motorout.Note,
                ProcessDate = motorout.ProcessDate,
                PartnerId = motorout.PartnerId,
                TransactionIdIn = motorout.TransactionIdIn,
                StationIdIn = motorout.StationIdIn,
                LaneIdIn = motorout.LaneIdIn,
                TransactionDateIn = motorout.TransactionDateIn,
                Price = motorout.Price,
                Total = motorout.Total,
                Minutes = motorout.Minutes,
                Barcode = motorout.Barcode,
                SerialNo = motorout.SerialNo,
                InvoiceNo = motorout.InvoiceNo,
                FormNo = motorout.FormNo,
                Serial = motorout.Serial,
                F0 = motorout.F0,
                F1 = motorout.F1,
                F2 = motorout.F2,
                F3 = motorout.F3,
                PlateHk = motorout.PlateHk,
                PlateO = motorout.PlateO,
                Code = motorout.Code,
                CreateUid = motorout.CreateUid,
                WriteUid = motorout.WriteUid
            };

            carinService.CreateMotorOut(motorOut);
            return View("privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}