 using System;
 using System.Windows.Forms;
 
 class MyButtonClass: Form
 {
    private Button mrButton;
    //Metod-конструктор
    public MyButtonClass()
    {
        mrButton = new Button();
        mrButton.Text = "Нажми меня";
        this.Controls.Add(mrButton);
    }
 
    //основной метод
    static void Main()
    {
        Application.Run(new MyButtonClass());
    }
 }