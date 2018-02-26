using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{

    [Serializable]
    public class CustomizedProduct
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string ImageUrl { get; set; }
        public string ShortSku { get; set; }
        public int ShadeId { get; set; }
      //  public RenderableArea AreaInfo { get; set; }
        public List<CustomizedImage> ImageSprites { get; set; }
        public List<CustomizedText> TextSprites { get; set; }
       // public List<CustomizedPattern> PatternSprites { get; set; }
        public DateTime DateUpdated { get; set; }
        public List<ZOrderInfo> ZOrderInfo { get; set; }
        public string SpriteUrl { get; set; }
        public int? VersionNumber { get; set; }
        public DateTime LastAccessedDate { get; set; }
        public bool IsSnapshot { get; set; }
        public bool IsReadOnly { get; set; }
        public int SubLocationCode { get; set; }
        public int SnapshotId { get; set; }
    }
}