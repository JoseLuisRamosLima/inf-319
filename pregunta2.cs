using System.Linq;
using System.Text;
using System.Threading.Task;
using System.Windows.Forms;

namespace Calculadora
{

	public partial class Form1 : Forms
	{
		public Form1()
		{
			InitializeComponent();

		}

		double a;
		double b;
		string c;

		
		public void button_Click(object sender, EventArgs e){
			valor = valor *10+ Convert.ToINt((Button)sender).Text;

			textBoxt.Text = valor.ToString();
		}


		private void multiplicacion_Click(object sender, Eventargs e)
		{
			a = Convert.ToDouble(this.txtpantalla.Text);
			c="*"
			this.txtpantalla.Clear();
			this.txtpantalla.Focus();
		}
		private void resta_Click(object sender, Eventargs e)
		{
			a = Convert.ToDouble(this.txtpantalla.Text);
			c="-"
			this.txtpantalla.Clear();
			this.txtpantalla.Focus();
		}
		private void suma_Click(object sender, Eventargs e)
		{
			a = Convert.ToDouble(this.txtpantalla.Text);
			c="+"
			this.txtpantalla.Clear();
			this.txtpantalla.Focus();
		}
		private void division_Click(object sender, Eventargs e)
		{
			a = Convert.ToDouble(this.txtpantalla.Text);
			c="/"
			this.txtpantalla.Clear();
			this.txtpantalla.Focus();
		}
		

		private void punto_Click(object sender, Eventargs e)
		{
			if(this.txtpantalla.Text.Contains('.') ==false)
			{
				this.txtpantalla.Text=this.txtpantalla.Text +".";
			}
		}

		private void igual_Click(object sender, Eventargs e)
		{
			b = Convert.ToDouble(this.txtpantalla.Text);
			switch(c)
			{
				case "+":
					this.txtpantalla.Text = Convert.ToString(b+a);
					break;
				case "-":
					this.txtpantalla.Text = Convert.ToString(b-a);
					break;
				case "*":
					this.txtpantalla.Text = Convert.ToString(b*a);
					break;
				case "/": 
					this.txtpantalla.Text = Convert.ToString(b/a);
					break;

			}
			c="*"
			this.txtpantalla.Clear();
			this.txtpantalla.Focus();
		}
		

		private void limpiar_Click(object sender, Eventargs e)
		{
			a = Convert.ToDouble("");
			b = Convert.ToDouble("");
			this.txtpantalla.Text = "";

		}
		
		
		



	}


}