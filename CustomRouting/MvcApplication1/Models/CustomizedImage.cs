using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    [Serializable]
    public class CustomizedImage
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int ZOrder { get; set; }
        public double OriginX { get; set; }
        public double OriginY { get; set; }
        public double Scale { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double RotationalDegree { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateUpdated { get; set; }
        public int CustomizedProductId { get; set; }
        public int? VersionNumber { get; set; }
        public DateTime LastAccessedDate { get; set; }
        public double? OriginalHeight { get; set; }
        public double? OriginalWidth { get; set; }
    }
}