﻿//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System.Drawing;

namespace ImageMagick
{
  ///<summary>
  /// Encapsulation of the ImageMagick geometry object.
  ///</summary>
  public sealed partial class MagickGeometry
  {
    ///<summary>
    /// Initializes a new instance of the MagickGeometry class using the specified rectangle.
    ///</summary>
    ///<param name="rectangle">The rectangle to use.</param>
    public MagickGeometry(Rectangle rectangle)
    {
      Initialize(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, false);
    }

    ///<summary>
    /// Converts the specified rectangle to an instance of this type.
    ///</summary>
    ///<param name="rectangle">The rectangle to use.</param>
    public static explicit operator MagickGeometry(Rectangle rectangle)
    {
      return new MagickGeometry(rectangle);
    }
  }
}