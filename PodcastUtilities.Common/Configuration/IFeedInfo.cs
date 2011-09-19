using System;

namespace PodcastUtilities.Common.Configuration
{
    /// <summary>
    /// configuration info for a podcast feed
    /// </summary>
    public interface IFeedInfo : ICloneable
    {
        /// <summary>
        /// the address of the podcast feed
        /// </summary>
        Uri Address { get; set; }

        /// <summary>
        /// the format the feed is in
        /// </summary>
        PodcastFeedFormat Format { get; set; }

        /// <summary>
        /// do not download podcasts that werre published before this number of days ago
        /// </summary>
        int MaximumDaysOld { get; set; }

        /// <summary>
        /// the naming style to use for episodes downloaded from the feed
        /// </summary>
        PodcastEpisodeNamingStyle NamingStyle { get; set; }

        /// <summary>
        /// the strategy to be used when downloading episodes
        /// </summary>
        PodcastEpisodeDownloadStrategy DownloadStrategy { get; set; }

        /// <summary>
        /// number of days before we delete a download
        /// </summary>
        int DeleteDownloadsDaysOld { get; set; }
    }
}