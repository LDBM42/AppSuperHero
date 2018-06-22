namespace PruebaXamarin.ViewModels
{
    using PruebaXamarin.Models;
    using PruebaXamarin.Sevices;
    using System;

    public class SuperHeroInfoViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion


        #region Attributes
        private Result heroInfo;
        private bool isRefreshing;
        private string img;
        //private ObservableCollection<Doc> articleObsCol;
        #endregion

        #region Properties
        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }

        public Result HerosIfo
        {
            get { return this.heroInfo; }
            set { SetValue(ref this.heroInfo, value); }
        }

        public string Img
        {
            get { return this.img; }
            set { SetValue(ref this.img, value); }
        }
        #endregion

        #region Constructor
        public SuperHeroInfoViewModel(Result herosInfo)
        {
            this.apiService = new ApiService();
            this.HerosIfo = herosInfo;
            this.Img = String.Format("{0}.{1}", herosInfo.Thumbnail.Path, herosInfo.Thumbnail.Extension);

        }
        #endregion
    }
}