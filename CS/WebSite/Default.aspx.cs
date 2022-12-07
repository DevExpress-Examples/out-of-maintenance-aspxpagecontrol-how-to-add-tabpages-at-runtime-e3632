using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxPageControl pageControl = new ASPxPageControl();
        pageControl.ID = "pageControl";
        Form.Controls.Add(pageControl);
        pageControl.TabPages.Add("Page 1", "Page 1");
        pageControl.TabPages.Add("Page 2", "Page 2");

        ASPxGridView grid = new ASPxGridView();
        grid.ID = "grid";
        pageControl.TabPages[0].Controls.Add(grid);
        grid.DataSource = AccessDataSource1;
        grid.DataBind();

        ASPxTextBox txt = new ASPxTextBox();
        txt.ID = "txt";
        txt.Text = "myTextBox";
        pageControl.TabPages[1].Controls.Add(txt);



    }
}
