using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsMediaPlayerV2.Model;

namespace WindowsMediaPlayerV2.ViewModel
{
    class ManagePlaylist
    {
        public PlaylistModel _playListModel;
        public ManagePlaylist()
            {
            }
        public void initPlaylist(PlaylistModel curPlay)
        {
            _playListModel = curPlay;
        }

        public void Previous()
        {
            if (_playListModel.CurrentIndex == 0)
                return;
            else
            _playListModel.CurrentIndex -= 1;
        }
        public void Next()
        {
            if (_playListModel.CurrentIndex == _playListModel.Medias.Count())
                _playListModel.CurrentIndex = 0;
            else
                _playListModel.CurrentIndex += 1;
        }
    }
}
