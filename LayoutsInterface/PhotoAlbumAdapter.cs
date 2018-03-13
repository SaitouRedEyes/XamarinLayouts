using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace LayoutsInterface
{
    //Essa classe infla o layout com os objetos que o holder construiu
    class PhotoAlbumAdapter : RecyclerView.Adapter
    {
        public PhotoAlbum myPhotoAlbum;

        public PhotoAlbumAdapter(PhotoAlbum photoAlbum)
        {
            myPhotoAlbum = photoAlbum;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.photo_card_view, parent, false);
            PhotoViewHolder vh = new PhotoViewHolder(itemView);

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            PhotoViewHolder vh = holder as PhotoViewHolder;
            vh.Image.SetImageResource(myPhotoAlbum[position]);
            //vh.Caption.Text = mPhotoAlbum[position].Caption;
        }

        public override int ItemCount
        {
            get { return myPhotoAlbum.NumPhotos; }
        }
    }
}