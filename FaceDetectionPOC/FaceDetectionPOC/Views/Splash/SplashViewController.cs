using System.Threading.Tasks;
using UIKit;
using FaceDetectionPOC.Views.ListController;



namespace FaceDetectionPOC
{
    public partial class SplashViewController : UIViewController
    {

		private AppDelegate AppDel =>  UIApplication.SharedApplication.Delegate as AppDelegate;

        protected UINavigationController NavController
        {
            get
            {
                return (UIApplication.SharedApplication.Delegate as AppDelegate).NavController;
            }
        }

        public SplashViewController() : base("SplashViewController", null)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            InitializeElements();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			NavController.NavigationBarHidden = true;
		}

		private void InitializeElements()
		{
            using (var viewController = new FaceMainController())
                NavController.ViewControllers = new UIViewController[] { viewController };
        }
    }
}

