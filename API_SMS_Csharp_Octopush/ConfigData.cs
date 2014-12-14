using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTestSmsSend
{
    class ConfigData
    {

        public String DOMAIN = "http://www.octopush-dm.com";
        public String PORT = "80";
        public String PATH_SMS = "/api/sms";
        public String PATH_BALANCE = "/api/balance/";
        public String QUALITE_STANDARD="xxx";
        public String QUALITE_PRO="fr";
        public String DIFFERE="2";
        public String INSTANTANE = "1";
      
        public String SIMULATION="simu";
        public String REEL="real";
		
        public String user_login = "***********@*****.***";
        public String api_key = "**********************";
		
        public String [] sms_recipients={"+33600001111","+33611110000"};
        public String [] recipients_first_names={"",""};
        public String sms_text="Appel moi  19:50";
        public String [] recipients_last_names={"",""};
        public String []sms_fields_1 = { "", "" };
        public String []sms_fields_2 = { "", "" };
        public String []sms_fields_3 = { "", "" };
        public String request_mode=REEL;
        public String sms_type = QUALITE_PRO;
        public String sms_mode=INSTANTANE;
        public String sms_d="18";      //  EN DIFFERE sera envoyé le 18-12-2013 à 19:50
        public String sms_m="12";
        public String sms_h="19";
        public String sms_i="50";
        public String sms_y="2013";
        public String sms_ticket="";
        public String sms_sender="Pub";


    }
}