// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FaceDetectionPOC.Views.ListController
{
	[Register ("MyListViewController")]
	partial class MyListViewController
	{
		[Outlet]
		UIKit.UIButton btnInfo { get; set; }

		[Outlet]
		UIKit.UITableView tblMainTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tblMainTable != null) {
				tblMainTable.Dispose ();
				tblMainTable = null;
			}

			if (btnInfo != null) {
				btnInfo.Dispose ();
				btnInfo = null;
			}
		}
	}
}
