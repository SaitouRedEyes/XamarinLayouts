using Android.App;
using Android.OS;
using Android.Support.V7.Widget;

namespace LayoutsInterface
{
    [Activity(Label = "MyRecycleView")]
    public class MyRecycleView : Activity
    {
        RecyclerView myRecyclerView;
        RecyclerView.LayoutManager myLayoutManager;
        PhotoAlbum myPhotoAlbum;
        PhotoAlbumAdapter myAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.my_recycler_view);

            //Instancia a fonte de dados e pega a referência do layout de RecycleView
            myPhotoAlbum = new PhotoAlbum();
            myRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            // Associa o gerenciador de layouts ao Recycler View (pode-se mudar a forma como os dados são apresentados)
            myLayoutManager = new LinearLayoutManager(this);
            myRecyclerView.SetLayoutManager(myLayoutManager);

            // Instancia um Adapter passando as fotos como parâmetro e associa o adapter ao Recycler View
            myAdapter = new PhotoAlbumAdapter(myPhotoAlbum);
            myRecyclerView.SetAdapter(myAdapter);
        }
    }
}