using System;

using UIKit;
using FaceDetectionPOC.Views.ListController.Source;
using FaceDetectionPOC.Views.ListController.Cell;

namespace FaceDetectionPOC.Views.ListController
{
    public partial class MyListViewController : UIViewController
    {
        private int counter = 0;
        private MyListTableSource source;

        public MyListViewController() : base("MyListViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupSource();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            AddEventHandlers();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            RemoveEventHandlers();

        }

        private void SetupSource()
        {
            //tblMainTable.RegisterNibForCellReuse(MyTableViewCell.Nib, "cell");
            source = new MyListTableSource();
            tblMainTable.Source = source;
        }

        #region EventHandlers
        private void AddEventHandlers()
        {
            btnInfo.TouchUpInside += BtnInfo_TouchUpInside;
        }

        private void RemoveEventHandlers()
        {
            btnInfo.TouchUpInside -= BtnInfo_TouchUpInside;
        }

        private void BtnInfo_TouchUpInside(object sender, EventArgs e)
        {
            source.TableItems.Add(counter.ToString());
            counter++;
            tblMainTable.ReloadData();
        }

        #endregion
    }
}

