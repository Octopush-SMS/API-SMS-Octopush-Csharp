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
    class SendSMS
    {
        static void Main(string[] args)
        {
            SMS sms = new SMS();
            ConfigData configData = new ConfigData();
          
            getBalance gb = new getBalance();
           
            sms.set_user_login(configData.user_login);
            sms.set_api_key(configData.api_key);
            sms.set_sms_type(configData.sms_type);

            sms.set_request_mode(configData.request_mode);
            
            sms.set_sms_recipients(configData.sms_recipients);
            sms.set_recipients_first_names(configData.recipients_first_names);
            sms.set_sms_text(configData.sms_text);
            sms.set_recipients_last_names(configData.recipients_last_names);
            sms.set_sms_fields_1(configData.sms_fields_1);
            sms.set_sms_fields_2(configData.sms_fields_2);
            sms.set_sms_fields_3(configData.sms_fields_3);
            sms.set_sms_mode(configData.sms_mode);
            if(configData.sms_mode ==configData.DIFFERE )
            {
            sms.set_sms_d(configData.sms_d);
            sms.set_sms_m(configData.sms_m);
            sms.set_sms_h(configData.sms_h);
            sms.set_sms_i(configData.sms_i);
            sms.set_sms_y(configData.sms_y);
            };
           string msg = sms.send(configData.DOMAIN , configData.PATH_SMS ,configData.PORT);
           String strErrCode=msg.Substring(msg.IndexOf("<error_code>") + 12, 3);
           if (strErrCode.Contains("000"))
               Console.WriteLine("Send Succes");
           else
               Console.WriteLine("Send Error: "+strErrCode);

                
                //Console.WriteLine(msg);// (XmlToString(msg, "erorr"));
           Console.ReadLine();
        }/*
        public static void XmlToString(string xmlMsg,String nodeNameToExtract)
        {
            XmlDocument xm = new XmlDocument();
           Console.WriteLine(xm.LoadXml(string.Format("<root>(0)<root>", xmlMsg)).);

        }*/
    }
}
