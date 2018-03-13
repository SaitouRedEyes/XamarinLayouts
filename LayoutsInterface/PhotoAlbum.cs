namespace LayoutsInterface
{
    /**
     * Esta classe é o molde de dados que será apresentado no Recycle View
     * Pode-se implementar nesta classe a propriedade de caption (legenda da foto), pois 
     * o componente (holder) que receberá esses dados já está preparado para isso  
     **/

    class PhotoAlbum
    {
        int[] thumbIds = {
            Resource.Drawable.sample_2, Resource.Drawable.sample_3,
            Resource.Drawable.sample_4, Resource.Drawable.sample_5,
            Resource.Drawable.sample_6, Resource.Drawable.sample_7,
            Resource.Drawable.sample_0, Resource.Drawable.sample_1,
            Resource.Drawable.sample_2, Resource.Drawable.sample_3,
            Resource.Drawable.sample_4, Resource.Drawable.sample_5,
            Resource.Drawable.sample_6, Resource.Drawable.sample_7,
            Resource.Drawable.sample_0, Resource.Drawable.sample_1,
            Resource.Drawable.sample_2, Resource.Drawable.sample_3,
            Resource.Drawable.sample_4, Resource.Drawable.sample_5,
            Resource.Drawable.sample_6, Resource.Drawable.sample_7
        };

        // Return the number of photos in the photo album:
        public int NumPhotos
        {
            get { return thumbIds.Length; }
        }

        // Indexer (read only) for accessing a photo:
        public int this[int i]
        {
            get { return thumbIds[i]; }
        }
    }
}