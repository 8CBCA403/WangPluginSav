using System;
using System.Windows.Forms;

namespace Test;

public class SafeDataGridView : DataGridView
{
	protected override void OnPaint(PaintEventArgs e)
	{
		try
		{
			base.OnPaint(e);
		}
		catch (Exception)
		{
			Invalidate();
		}
	}
}
