namespace SQLEditor
{
  partial class Form1
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtEditor = new System.Windows.Forms.TextBox();
      this.btnBuscaProcedure = new System.Windows.Forms.Button();
      this.txtNomePc = new System.Windows.Forms.TextBox();
      this.btnLimpar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtEditor
      // 
      this.txtEditor.Location = new System.Drawing.Point(4, 38);
      this.txtEditor.MaxLength = 0;
      this.txtEditor.Multiline = true;
      this.txtEditor.Name = "txtEditor";
      this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtEditor.Size = new System.Drawing.Size(1195, 532);
      this.txtEditor.TabIndex = 3;
      this.txtEditor.WordWrap = false;
      // 
      // btnBuscaProcedure
      // 
      this.btnBuscaProcedure.Location = new System.Drawing.Point(238, 10);
      this.btnBuscaProcedure.Name = "btnBuscaProcedure";
      this.btnBuscaProcedure.Size = new System.Drawing.Size(99, 22);
      this.btnBuscaProcedure.TabIndex = 1;
      this.btnBuscaProcedure.Text = "Buscar";
      this.btnBuscaProcedure.UseVisualStyleBackColor = true;
      this.btnBuscaProcedure.Click += new System.EventHandler(this.BtnBuscaProcedure_Click);
      // 
      // txtNomePc
      // 
      this.txtNomePc.Location = new System.Drawing.Point(4, 10);
      this.txtNomePc.Name = "txtNomePc";
      this.txtNomePc.Size = new System.Drawing.Size(228, 20);
      this.txtNomePc.TabIndex = 0;
      this.txtNomePc.Text = "PcImportaNfe";
      // 
      // btnLimpar
      // 
      this.btnLimpar.Location = new System.Drawing.Point(343, 9);
      this.btnLimpar.Name = "btnLimpar";
      this.btnLimpar.Size = new System.Drawing.Size(75, 23);
      this.btnLimpar.TabIndex = 4;
      this.btnLimpar.Text = "Limpar";
      this.btnLimpar.UseVisualStyleBackColor = true;
      this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1211, 582);
      this.Controls.Add(this.btnLimpar);
      this.Controls.Add(this.txtNomePc);
      this.Controls.Add(this.btnBuscaProcedure);
      this.Controls.Add(this.txtEditor);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtEditor;
    private System.Windows.Forms.Button btnBuscaProcedure;
    private System.Windows.Forms.TextBox txtNomePc;
    private System.Windows.Forms.Button btnLimpar;
  }
}

