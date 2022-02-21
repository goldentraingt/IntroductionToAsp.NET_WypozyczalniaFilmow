using System;

namespace IntroductionToAsp.NET_WypozyczalniaFilmow.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
