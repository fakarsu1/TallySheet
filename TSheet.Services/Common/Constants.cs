using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSheet.Services.Common
{
    public class Constants
    {
        public enum ERROR_ENUMS
        {
            SUCCESS,
            INVALID_USERNAME_OR_PASSWORD,
            SYSTEM

        }

        public static Dictionary<int, string> ERROR_CODES = new Dictionary<int, string>
      {
          {0,"Başarılı" },
          {1,"Kullanıcı adı veya şifre hatalı" },
          {2,"Sistemsel bir hata oluştu .Lütfen yönetinizi aranıyın!!" }

      };


    }
}
