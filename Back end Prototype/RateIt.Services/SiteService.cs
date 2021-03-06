﻿using RateIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateIt.Services.Interfaces;
using RateIt.Repositories.Interfaces;

namespace RateIt.Services
{
    public class SiteService : ISiteService
    {
        private readonly IRepository<Site> _siteRepository;

        public SiteService(IRepository<Site> siteRepository)
        {
            _siteRepository = siteRepository;
        }

        public Site GetSiteByUrl(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var cleanName = GetCleanName(url);
                if (cleanName != null)
                    return _siteRepository.GetAll()
                        .FirstOrDefault(x => x.Name == cleanName);
            }
            return null;
        }

        public string GetCleanName(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var uri = new Uri(url);
                return uri.Host.ToLower();
            }
            return null;
        }

        public Site AddSite(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                // Create site to add
                var site = new Site()
                {
                    AccountId = null,
                    Name = GetCleanName(url),
                    Timestamp = DateTime.Now
                };
                // Add and return
                _siteRepository.Add(site);
                if (Convert.ToBoolean(_siteRepository.Save())) 
                    return site;
            }
            return null;
        }

        public Site FindOrInsertSite(string url)
        {
            if (url != null) {
                var site = GetSiteByUrl(url);
                if (site != null)
                    return site;
                return AddSite(url);
            }
            return null;
        }

        public Site GetSiteById(long siteId)
        {
            return _siteRepository.GetAll()
                .FirstOrDefault(x => x.Id == siteId);
        }
    }
}
