using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using UnityEngine;

namespace UnityMobileModules
{
    public static partial class DeepLinking
    {
        /// <summary>
        /// Regex string used to extract Deep Link components
        /// </summary>
        const string deeplinkRegex = "(\\S+):\\/\\/(\\S+)\\/(\\S+)\\?(\\S+)";

        /// <summary>
        /// Cached URI, won't change during app runtime
        /// </summary>
        static string cached_uri = null;

        /// <summary>
        /// Cached Scheme
        /// </summary>
        static string cached_scheme = null;

        /// <summary>
        /// Cached Host
        /// </summary>
        static string cached_host = null;

        /// <summary>
        /// Cached Path
        /// </summary>
        static string cached_path = null;

        /// <summary>
        /// Cached Query
        /// </summary>
        static string cached_query = null;

        /// <summary>
        /// Gets the URI the app was opened with
        /// </summary>
        public static string uri
        {
            get
            {
                if (cached_uri != null) return cached_uri;
#if UNITY_EDITOR
                cached_uri = "scheme://host/path?query=value";
#elif UNITY_ANDROID
                cached_uri = GetDeepLinkURI_Android;
#elif UNITY_IOS

#endif
                //don't try to regex a empty string
                if (cached_uri == "")
                {
                    cached_scheme = "";
                    cached_host = "";
                    cached_path = "";
                    cached_query = "";
                    return cached_uri;
                }

                var match = Regex.Matches(cached_uri, deeplinkRegex)[0];
                //index 0 is the full string
                cached_scheme = match.Groups[1].Value;
                cached_host = match.Groups[2].Value;
                cached_path = match.Groups[3].Value;
                cached_query = match.Groups[4].Value;

                return cached_uri;
            }
        }

        /// <summary>
        /// Deep Link Scheme
        /// </summary>
        public static string scheme
        {
            get
            {
                if (cached_scheme != null) return cached_scheme;

                //this checks to see if the uri is null, if it is, it will grab the URI and attempt to regex it
                var _uri = uri;

                return cached_scheme;
            }
        }

        /// <summary>
        /// Deep Link Host
        /// </summary>
        public static string host
        {
            get
            {
                if (cached_host != null) return cached_host;

                //this checks to see if the uri is null, if it is, it will grab the URI and attempt to regex it
                var _uri = uri;

                return cached_host;
            }
        }

        /// <summary>
        /// Deep Link Path
        /// </summary>
        public static string path
        {
            get
            {
                if (cached_path != null) return cached_path;

                //this checks to see if the uri is null, if it is, it will grab the URI and attempt to regex it
                var _uri = uri;

                return cached_path;
            }
        }

        /// <summary>
        /// Deep Link Query
        /// </summary>
        public static string query
        {
            get
            {
                if (cached_query != null) return cached_query;

                //this checks to see if the uri is null, if it is, it will grab the URI and attempt to regex it
                var _uri = uri;

                return cached_query;
            }
        }
    }
}
