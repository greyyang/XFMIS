using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CodeGeneratorWin.CustomProperty
{
    public class PropertyGridFolderItem : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if (edSvc != null)
            {
                // 可以打开任何特定的对话框
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                if (dialog.ShowDialog().Equals(DialogResult.OK))
                {
                    return dialog.SelectedPath;
                }
            }
            return value;
        }
    }
}