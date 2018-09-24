﻿using System.Collections.Generic;

namespace cln.Sources.Services
{
    public static class Services
    {
        private static List<IService> _services = new List<IService>();

        public static void Initialize()
        {
            _services.Add(new DataService());
            _services.Add(new GpgService());
            _services.Add(new AdService());
            _services.Add(new AudioService());

            foreach (var service in _services)
            {
                service.Initialize();
            }
        }

        public static DataService GetDataService()
        {
            return (DataService) _services[0];
        }

        public static GpgService GetGpgService()
        {
            return (GpgService) _services[1];
        }

        public static AdService GetAdService()
        {
            return (AdService) _services[2];
        }

        public static AudioService GetAudioService()
        {
            return (AudioService) _services[3];
        }
    }
}