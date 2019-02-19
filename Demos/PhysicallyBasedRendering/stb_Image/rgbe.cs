﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stb_Image {
    public struct rgbe_header_info {
        /// <summary>
        /// indicate which fields are valid.
        /// </summary>
        int valid;
        /// <summary>
        /// listed at beginning of file to identify it after "#?".  defaults to "RGBE".
        /// </summary>
        char[] programtype; // new char[16];
        /// <summary>
        /// image has already been gamma corrected with given gamma.  defaults to 1.0 (no correction) 
        /// </summary>
        float gamma;
        /// <summary>
        /// a value of 1.0 in an image corresponds to &lt;exposure&gt; watts/steradian/m^2. defaults to 1.0
        /// </summary>
        float exposure;

    }

}
