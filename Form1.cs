using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace koledar
{
    public partial class Koledar : Form
    {
        public Koledar()
        {
            InitializeComponent();
        }
        private void ReadFile()
        {
            
            string[] lines = System.IO.File.ReadAllLines(@".\prazniki.txt");
            System.Console.WriteLine("Contents of prazniki.txt = ");
            //prebermo praznike po vrsticah
            foreach (string line in lines)
            {
                //PRaznike so zapisani v vrsticah, in razdeljenje z ;
                string[] praznik = line.Split(';');
                //datum preberem posebej
                string[] datum = praznik[2].Split('.');
                //ker lahko ponavljajoč praznik pišemo brez letnice dodamo 0 na to mesto...
                if (datum[2] == "")
                    datum[2] = "0";
                Prazniki.Add(new Praznik
                {
                    imePraznika = praznik[0],
                    ponavljajoce = Convert.ToBoolean(praznik[1]),
                    dan = Int16.Parse(datum[0]),
                    mesec = Int16.Parse(datum[1]),
                    leto = Int16.Parse(datum[2])
                });
                Console.WriteLine("\t" + line);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stevilodni"></param>
        /// <param name="Zamik"></param>
        /// <param name="mesec"></param>
        /// <param name="leto"></param>
        /// <returns>vrne listo dni v mescu s prazniki</returns>
        private List<Day> MesecPrazniki(int stevilodni,int Zamik,int mesec,int leto)
        {   
            
            var mesecPrazniki = new List<Day>();
            //da izpišemo točno število dni
            for (int i = 1; i < stevilodni+Zamik; i++)
            {
                //da lahko dodamo prazna polja na začetku izpisa 
                if ((i + stevilodni) < (Zamik+stevilodni))
                    mesecPrazniki.Add(new Day() { Datum = 0 });
                else
                    mesecPrazniki.Add(new Day() { Datum = (i-Zamik)+1 });     
            }
            foreach (var item in Prazniki)
            {
                //zapis praznikov glede na to, če so ponavljajoči
                if (mesec == item.mesec&&item.ponavljajoce)
                {
                    mesecPrazniki[item.dan +Zamik-2].imePraznika = item.imePraznika;
                }
                else if(mesec == item.mesec && leto == item.leto)
                {
                    mesecPrazniki[item.dan + Zamik-2].imePraznika = item.imePraznika;
                }
            }
            return mesecPrazniki;
        }
        List<Praznik> Prazniki = new List<Praznik>();
        private void IzpisKoledarja(int StDniMescu,int zamik,int mesec,int leto)
        {
            //pomožna lista za izpis
            var ListMesec = MesecPrazniki(StDniMescu, zamik,mesec,leto);
            ListViewItem lvi = new ListViewItem("koledar");
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 100);
            listView1.SmallImageList = imgList;
            int index = 0;
            foreach (var dan in ListMesec)
            {
                index++;
                var temp = dan.Datum.ToString();
                if (listView1.Items.Count == 0)
                {//v primeru da je prvi datum praznik in je pozicioniran v prvi celici
                    if (temp == "1")
                    {
                        if (dan.imePraznika == null)
                        {
                            ListViewItem li = new ListViewItem();
                            li.UseItemStyleForSubItems = false;
                            li.ForeColor = Color.Black;
                            li.Font = new Font("Arial", 14);
                            li.Text = "         1";
                            listView1.Items.Add(li);
                            continue;
                        }
                        else
                        {
                            ListViewItem li = new ListViewItem();
                            li.UseItemStyleForSubItems = false;
                            li.ForeColor = Color.Red;
                            li.Font = new Font("Arial", 14);
                            li.Text = "         1 \n       " + dan.imePraznika;
                            listView1.Items.Add(li);
                            continue;
                        }           
                    }
                    //dodajanjem praznih celic, da so datumi poravnani s dnevi v tednu
                    else if (temp == "0")
                    {
                        listView1.Items.Add("");
                        continue;
                    }
                }
                if (temp == "0")
                {//dodajanjem praznih celic, da so datumi poravnani s dnevi v tednu
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem(lvi,"", Color.Black, Color.White, new Font("Arial", 14)));
                    continue;
                }
                else if (index % 7 == 0)
                {
                //ob koncu vrstice izpišemo nedeljo drugačne barve in dodamo novo vrstico
                    listView1.Items[listView1.Items.Count - 1].UseItemStyleForSubItems = false;
                    lvi.UseItemStyleForSubItems = false;
                    //Preverjamo če je praznik
                    if (dan.imePraznika == null)
                    {   
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem(lvi, temp, Color.Black, Color.SkyBlue, new Font("Arial", 14)));
                        ListViewItem li = new ListViewItem();
                        li.UseItemStyleForSubItems = false;
                        li.ForeColor = Color.Black;
                        li.Font = new Font("Arial",14);
                        //ker ob koncu vrstice dodam novo preverjam robni primer ob koncu meseca
                        if (dan.Datum != StDniMescu)
                            //praznik
                            if( ListMesec[index].imePraznika == null)
                            {
                                li.Text = "         " + (dan.Datum + 1).ToString();
                                listView1.Items.Add(li);
                            }
                            else
                            {
                                li.ForeColor = Color.Red;
                                li.Font = new Font("Arial", 14);
                                li.Text = "         " + (dan.Datum + 1 + "\n" + ListMesec[index].imePraznika).ToString();
                                listView1.Items.Add(li);
                            }
                    }
                    else
                    {//če je zadnji dan praznik ga izpišem v drugačni barvi
                        ListViewItem li = new ListViewItem();
                        lvi.UseItemStyleForSubItems = false;
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem(lvi, temp+ "\n" + dan.imePraznika, Color.Red, Color.SkyBlue, new Font("Arial", 14)));
                        if (dan.Datum != StDniMescu )
                            if( ListMesec[index].imePraznika == null)
                            {
                                lvi.UseItemStyleForSubItems = false;
                                li.Text = "         " + (dan.Datum + 1).ToString();
                                li.Font = new Font("Arial", 14);
                                listView1.Items.Add(li);
                            } 
                            else
                            {
                                //ListViewItem li = new ListViewItem();
                                li.UseItemStyleForSubItems = false;
                                li.ForeColor = Color.Red;
                                li.Font = new Font("Arial", 14);
                                li.Text = ("         "+(dan.Datum + 1) + "\n" + ListMesec[index].imePraznika).ToString();
                                listView1.Items.Add(li);
                            }  
                    }  
                }
                else
                {   //ker imamo v novi vrstici že en element ga moramo zato preskočiti
                    if ((index - 1) % 7 == 0&& (dan.Datum - 1)>0)
                        continue;
                    //ostale dni normalno izpišemo gled na to ali so prazniki ali ne
                    if (dan.imePraznika == null)
                    {
                        lvi.UseItemStyleForSubItems = false;
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem(lvi,temp, Color.Black, Color.White, new Font("Arial", 14)));
                    }
                    else
                    {

                        lvi.UseItemStyleForSubItems = false;
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewItem.ListViewSubItem(lvi,temp+"\n"+dan.imePraznika, Color.Red, Color.White, new Font("Arial", 18)));
                    }
                }  
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            AlgoritemiKoledar alg=new  AlgoritemiKoledar();
            try
            {
                ReadFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri branju datoteke!"+"\n"+ex.Message);
                Console.WriteLine(ex.Message);
                //throw;
            }
            DateTime thisDay = DateTime.Today;
            int danVTednu = alg.AlgoritemKoledar(thisDay.Year, thisDay.Month, 1);
            int stDniVMescu = alg.GetDaysInmonth(thisDay.Month, thisDay.Year);
            //izpis v formo trenutnega mesca
            labelMesec.Text = comboBoxMonth.Items[thisDay.Month-1].ToString();
            labelLeto.Text = thisDay.Year.ToString();
            IzpisKoledarja(stDniVMescu, danVTednu, thisDay.Month, thisDay.Year);
        }
        

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            //pridobimo datum iz textbox
            try
            {
                int leto = Int16.Parse(textBoxYear.Text);
                int mesec = comboBoxMonth.SelectedIndex + 1;
                AlgoritemiKoledar alg = new AlgoritemiKoledar();
                //klic na AlgoritemKoledar, kjer pridobimo dneve v tednu
                int danVTednu = alg.AlgoritemKoledar(leto, mesec, 1);
                int stDniVMescu = alg.GetDaysInmonth(mesec, leto);
                listView1.Items.Clear();
                IzpisKoledarja(stDniVMescu, danVTednu, mesec, leto);

                //prikaz na formi
                labelMesec.Text = comboBoxMonth.Items[mesec - 1].ToString();
                labelLeto.Text = leto.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prosim vpišite leto v obliki YYYY in izberite mesec! ");
                Console.WriteLine(ex.Message);
               // throw;
            }
        }
        private void buttonSkok_Click(object sender, EventArgs e)
        {
            AlgoritemiKoledar alg = new AlgoritemiKoledar();
            if (TextDate.Text != "")
            {
                try
                {
                    string[] datum = TextDate.Text.Split('.');
                    int dan =Int16.Parse(datum[0]);
                    int mesec = Int16.Parse(datum[1]);
                    int leto = Int16.Parse(datum[2]);
                    int stDniVMescu = alg.GetDaysInmonth(mesec, leto);
                    if (dan <= 0 || dan > stDniVMescu)
                        throw new Exception("nepravilen zapis datuma");
                    
                    int danVTednu = alg.AlgoritemKoledar(leto, mesec, 1);
                    
                    listView1.Items.Clear();
                    IzpisKoledarja(stDniVMescu, danVTednu, mesec, leto);
                    labelMesec.Text = comboBoxMonth.Items[mesec - 1].ToString();
                    labelLeto.Text = leto.ToString();
                }
                catch (Exception ex)
                {

                     MessageBox.Show("Napačna oblika zapisa, datum morate zapisati v obliki DD.MM.YYYY!");
                     Console.WriteLine(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("PROSIM VNESITE DATUM V OBLIKI DD.MM.YYYY!");
            }
           
        }
    }
}
