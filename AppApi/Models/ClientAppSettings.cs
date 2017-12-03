using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppApi.Models
{
    public class ClientAppSettings
    {

        public ClientAppSettings()
        {
            stsServer = "http://localhost:15107";
            redirect_url = "https://localhost:44311";
            client_id = "angularclient";
            response_type = "id_token token";
            scope = "dataEventRecords securedFiles openid profile";
            post_logout_redirect_uri = "https://localhost:44311/";
            start_checksession = true;
            silent_renew = true;
            startup_route = "/dataeventrecords";
            forbidden_route = "/forbidden";
            unauthorized_route = "/unauthorized";
            log_console_warning_active = true;
            log_console_debug_active = true;
            max_id_token_iat_offset_allowed_in_seconds = "10";
            apiServer = "https://localhost:44390/";
            apiFileServer = "https://localhost:44378/";
        }

        public string stsServer { get; set; }
        public string redirect_url { get; set; }
        public string client_id { get; set; }
        public string response_type { get; set; }
        public string scope { get; set; }
        public string post_logout_redirect_uri { get; set; }
        public bool start_checksession { get; set; }
        public bool silent_renew { get; set; }
        public string startup_route { get; set; }
        public string forbidden_route { get; set; }
        public string unauthorized_route { get; set; }
        public bool log_console_warning_active { get; set; }
        public bool log_console_debug_active { get; set; }
        public string max_id_token_iat_offset_allowed_in_seconds { get; set; }
        public string apiServer { get; set; }
        public string apiFileServer { get; set; }
    }

}

