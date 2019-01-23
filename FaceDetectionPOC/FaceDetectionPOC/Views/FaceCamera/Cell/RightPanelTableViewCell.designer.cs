// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FaceDetectionPOC.Views.FaceCamera.Cell
{
	[Register ("RightPanelTableViewCell")]
	partial class RightPanelTableViewCell
	{
		[Outlet]
		UIKit.UILabel lblText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblText != null) {
				lblText.Dispose ();
				lblText = null;
			}
		}
	}
}
