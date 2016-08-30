﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace CSharpGL.Demos
{
    /// <summary>
    /// Raycast Volume Rendering Demo.
    /// </summary>
    partial class RaycastVolumeRenderer : RendererBase
    {
        private Renderer backfaceRenderer;
        private Renderer raycastRenderer;
        private Texture transferFunc1DTexture;
        private Texture backface2DTexture;
        //private uint[] vol3DTexObj = new uint[1];
        private Texture volume3DTexture;
        private uint[] frameBuffer = new uint[1];

        private static readonly IBufferable model = new RaycastModel();
        private float g_stepSize = 0.001f;

        public void SetMVP(mat4 mvp)
        {
            this.backfaceRenderer.SetUniform("MVP", mvp);
            this.raycastRenderer.SetUniform("MVP", mvp);
        }

        protected override void DisposeUnmanagedResources()
        {
            this.backfaceRenderer.Dispose();
            this.raycastRenderer.Dispose();
            this.transferFunc1DTexture.Dispose();
            this.backface2DTexture.Dispose();
            this.volume3DTexture.Dispose();
            OpenGL.DeleteFrameBuffers(1, frameBuffer);
        }

    }
}