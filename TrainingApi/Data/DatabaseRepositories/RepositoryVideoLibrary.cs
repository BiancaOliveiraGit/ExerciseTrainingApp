using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public partial class Repository 
    {
        public VideoLibrary GetVideoById(int id)
        {
            try
            {
                var item = _appDbContext.VideoLibraries.Where(w => w.VideoLibraryId == id)
                                        .Select(s => s).FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public IEnumerable<VideoLibrary> GetVideoLibraries()
        {
            try
            {
                var list = _appDbContext.VideoLibraries.Select(s => s).ToList();
                return list;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public VideoLibrary PostNewVideo(VideoLibrary newVideo)
        {
            try
            {
                //check that video doesn't exist
                var exists = _appDbContext.VideoLibraries.Where(w => w.VideoUrl == newVideo.VideoUrl && w.DoNotUse == false)
                                                  .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new Exception("Video link already exists");

                var item = _appDbContext.Add(newVideo);
                item.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var isOk = _appDbContext.SaveChanges();

                return item.Entity;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public VideoLibrary UpdateVideo(int id, VideoLibrary updateVideo)
        {
            try
            {
                //check that video  exists
                var existingVid = _appDbContext.VideoLibraries.Where(w => w.VideoLibraryId == updateVideo.VideoLibraryId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingVid != null)
                    throw new Exception(string.Format("VideoLibraryID {0},- {1} Doesn't Exist in system", updateVideo.VideoLibraryId, updateVideo.AltTag));

                //update video
                existingVid.AltTag = updateVideo.AltTag;
                existingVid.ModifiedDate = DateTime.Now;
                existingVid.VideoUrl = updateVideo.VideoUrl;
                existingVid.DoNotUse = updateVideo.DoNotUse;

                var isOk = _appDbContext.SaveChanges();

                return existingVid;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }
    }
}
