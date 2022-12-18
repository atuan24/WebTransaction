using System;

namespace WebTransaction.Helper
{
    public class UploadHelper
    {
        public string GenerateFileName(string fileName)
        {
            var Datetime = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            var lastIndex = fileName.LastIndexOf("."); // lấy vị trí dấu . cuối cùng
            var ext = fileName.Substring(lastIndex); // lấy chuỗi từ vị trí của dấu . cuối cùng đến hết chuỗi
            var guid = Guid.NewGuid().ToString().Replace("-", "");
            return guid + ext ;
        }
        
    }
}
