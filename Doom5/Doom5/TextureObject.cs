﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Doom5 {
    class TextureObject {
        
        Image Texture { get; set; }

        TextureObject(Image texture, Point point, int length, int width) {
            Texture = texture;
        }
    }
}