using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Xml ;
using System.Text.RegularExpressions;

namespace OctopushSMS
{
    public class SMS
    {
        
        
       
        //*****************************************//
       // NameValueCollection nameValueCollection;
       
        //****************************************//
        private String user_login;
        private String api_key ;
        private String QUALITE_STANDARD;
        private String QUALITE_PRO;
        private String sms_type;
        private String SIMULATION;
        private String REEL;
        private String request_mode;
        private String DIFFERE;
        private String[] sms_recipients ;
        private String[] recipients_first_names;
        private String sms_text;
        private String[] recipients_last_names ;
        private String[] sms_fields_1;
        private String[] sms_fields_2;
        private String INSTANTANE;
        private String[] sms_fields_3;
        private String sms_mode;
        private String sms_d;
        private String sms_m;
        private String sms_h;
        private String sms_i;
        private String sms_y;
        private string  sms_ticket;
        private string sms_sender;

  

        DateTime t;
        public SMS()
        {

           this.t = new DateTime();
                             
}

        //  s.Split(' ');  
       // string.Join(",", arr)
    //public String send(String configFileNamePath)
        public String send(String domain, String path, String port)
    {
        NameValueCollection nameValueCollection = new NameValueCollection()
        {
             {"user_login",this.user_login},
              {"api_key" ,this.api_key},
              {"sms_recipients", string.Join(",", this.sms_recipients) },
              {"recipients_first_names", string.Join(",",this.recipients_first_names) },
              {"sms_text" ,this.sms_text },
             {"recipients_last_names", string.Join(",",this.recipients_last_names )},
             {" sms_fields_1", string.Join(",",this.sms_fields_1) },  
             {" sms_fields_2", string.Join(",",this.sms_fields_2 )},  
             {" sms_fields_3", string.Join(",",this.sms_fields_3) },  
            {"  sms_mode",this.sms_mode },  
             {" sms_d",this.sms_d },  
             {" sms_m",this.sms_m },  
             {" sms_h",this.sms_h },  
              {" sms_i",this.sms_i },  
              {" sms_y",this.sms_y },    
              {"sms_ticket",this.sms_ticket},    
              {"sms_sender",this.sms_sender},
              {"sms_type",this.sms_type },
              {"request_mode",this.request_mode }
      
      
       
        };
           
		
        //readConfigFile(configFileNamePath);
        return (httpRequest(domain, path, port, nameValueCollection));

    }
    public string getBalance(String domain1,String path1,String port1)
	{
        string domain= domain1;
		string path = path1;
		string port = port1;
        NameValueCollection data = new NameValueCollection()
            {
              {"user_login",this.user_login},
              {"api_key" ,this.api_key},
             
             
              
              
            };
		return  (httpRequest(domain, path, port, data));
	}
       // public 

	private String httpRequest(String domain,String path,String port,NameValueCollection A_fields )
	{
        
		
        int i = 0 ; 
		String []qs = new string [100];
		foreach (String k in A_fields .Keys)
		{
			qs[i++] = k + "="+ A_fields[k];
            
		}

		String strRequest = String.Join("&", qs,0,i);

       
       WebRequest request = WebRequest.Create(domain +":"+port+path+"?"+strRequest); 
        request.Method = "POST";    
     
        WebResponse webResponse;
        string result="";
        try{ 
            webResponse=request.GetResponse();
            using (var reader = new StreamReader(webResponse.GetResponseStream()))
            {
                result = reader.ReadToEnd(); // do something fun...
            }
        }
        catch (Exception e)
        {
            if (e.Source != null)
                Console.WriteLine("Exception source: {0}", e.Data.ToString());
        }
		return result ;
	}




    private String[] split(String text_box)
    {

        Regex r = new Regex(",", RegexOptions.IgnorePatternWhitespace);
        return Regex.Split(text_box, "=");
    }













    
        
   

    public void set_sms_ticket(String sms_ticket)
    {
        this.sms_ticket = sms_ticket;
    }
    public void set_sms_sender(String sms_sender)
    {
        this.sms_sender = sms_sender;
    }

	public void set_user_login(String user_login)
	{
		this.user_login = user_login;
	}

    public void set_api_key(String api_key)
	{
		this.api_key = api_key;
	}
    public void set_QUALITE_STANDARD(String QUALITE_STANDARD)
    {
        this.QUALITE_STANDARD = QUALITE_STANDARD;
    }
    public void set_QUALITE_PRO(String QUALITE_PRO)
    {
        this.QUALITE_PRO = QUALITE_PRO;
    }
    public void set_sms_type(String sms_type)
    {
        this.sms_type = sms_type;
    }
    public void set_SIMULATION(String SIMULATION)
    {
        this.SIMULATION = SIMULATION;
    }
    public void set_REEL(String REEL)
    {
        this.REEL = REEL;

    }
    public void set_request_mode(String request_mode)
    {
        this.request_mode = request_mode;
    }
    public void set_DIFFERE(String DIFFERE)
    {
        this.DIFFERE = DIFFERE;
    }
    public void set_sms_recipients(String[] sms_recipients)
    {
        this.sms_recipients = sms_recipients;
    }
    public void set_recipients_first_names(String [] recipients_first_names)
    {
        this.recipients_first_names =  recipients_first_names;

    }
    public void set_sms_text(String sms_text)
    {
        this.sms_text = sms_text;
    }
    public void set_recipients_last_names(String[] recipients_last_names)
    {
        this.recipients_last_names = recipients_last_names;
    }
    public void set_sms_fields_1(String []sms_fields_1)
    {
        this.sms_fields_1 = sms_fields_1;
    }
    public void set_sms_fields_2(String []sms_fields_2)
    {
        this.sms_fields_2 = sms_fields_2;
    }
    public void set_sms_fields_3(String []sms_fields_3)
    {
        this.sms_fields_3 = sms_fields_3;
    }
  
    public void set_sms_mode(String sms_mode)
    {
        this.sms_mode = sms_mode;
    }
    public void set_sms_d(String sms_d)
    {
        this.sms_d = sms_d;

    }
    public void set_sms_m(String sms_m)
    {
        this.sms_m = sms_m;
    }
    public void set_sms_h(String sms_h)
    {
        this.sms_h = sms_h;
    }
    public void set_sms_i(String sms_i)
    {
        this.sms_i = sms_i;
    }
    public void set_sms_y(String sms_y)
    {
        this.sms_y = sms_y;

   
    }
  
}







}
