/*
 * Pixel Framework
 * 
 * This framework allows you to develop games for mobile devices even faster than you normally do.
 * It includes a lot of useful classes, resources, and examples to get your project started.
 * The framework will be especially useful for developers of hyper-casual games.
 *
 * This framework was developed specifically for Pixel Incubator members with the support of TinyPlay.
 * You can read more about Incubator at the official website:
 * https://pixinc.club/
 *
 * @developer       Ilya Rastorguev
 * @autor           TinyPlay, Inc.
 * @version         1.0
 * @url             https://pixinc.club/
 * @support         https://github.com/TinyPlay/PixelFramework/issues
 * @discord         https://discord.gg/wE67T7Vm
 */
namespace PixelFramework.Models.Locale
{
    using System.Collections.Generic;
    using UnityEngine;
    
    [System.Serializable]
    public class LocalizedImagesModel
    {
        [System.Serializable]
        public class LocalizedImage
        {
            public string Locale = "";
            public Sprite Sprite = null;
        }

        // Items
        public List<LocalizedImage> ImagesData = new List<LocalizedImage>();
    }
}