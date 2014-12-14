using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OctopushSMS;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace ConsoleApplicationTestSmsSend
{
    class getBalance
    {
        public getBalance()
        {
            SMS sms = new SMS();
            ConfigData configData = new ConfigData();
            sms.set_api_key (configData.api_key);
            sms.set_user_login (configData.user_login );
            Console.WriteLine(sms.getBalance(configData.DOMAIN, configData.PATH_BALANCE, configData.PORT));
            string msg = sms.getBalance(configData.DOMAIN, configData.PATH_BALANCE, configData.PORT);
            String frleft = msg.Substring(msg.IndexOf("<balance type=\"FR\">") +19, 6);
            Console.WriteLine(frleft + "your fr left");
            string xxxleft = msg.Substring(msg.IndexOf("<balance type=\"XXX\">") +20, 6);
            Console.WriteLine(xxxleft + "your xxx left");

        }


    }
}