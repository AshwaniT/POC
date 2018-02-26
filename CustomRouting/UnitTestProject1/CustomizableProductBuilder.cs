using System.Collections.Generic;
using MvcApplication1.Models;

namespace UnitTestProject1
{
    //Fluent based 
   public class CustomizableProductBuilder
    {
        public CustomizedProduct Product;

        public CustomizableProductBuilder()
        {
            Product = new CustomizedProduct
            {
                ZOrderInfo = new List<ZOrderInfo>(),
                TextSprites = new List<CustomizedText>(),
                ImageSprites = new List<CustomizedImage>(),
                ShortSku = "OneTwoThree"
            };
        }

        public CustomizableProductBuilder AddText(string text, int id, int zOrder)
        {
            Product.TextSprites.Add(new CustomizedText
            {
                IsBold = true,
                IsItalic = true,
                Text = text,
                Id = id,
                OriginX = 2,
                OriginY = 3,
                ZOrder = zOrder,
                RotationalDegree = 12,
                Red = 255,
                Blue = 10,
                Green = 10,
                FontStyle = "indieflower",
                FontSize = 15

            }

                );
            Product.ZOrderInfo.Add(new ZOrderInfo
            {
                SpriteType = SpriteType.Text,
                ZOrder = zOrder,
                SpriteId = id
            });
            return this;
        }
    }
}
