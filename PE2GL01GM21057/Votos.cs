using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2GL01GM21057
{
    internal class Votos
    {
      
        int[,] votos = { {190,234,389,178,264,375,453},
        {45,176,65,85,62,143,46},
        {36,86,64,45,187,23,173},
        {37,53,23,6,53,254,24},
        {74,4,8,9,23,57,8}};

        public Votos()
        {
           
        }

        public void MostrarDatos(DataGridView dataGridVotos, DataGridView dataGridPartidosVotos, DataGridView dataGridTotalVotos, DataGridView dataGridGanadores)
        {
            int totalVotos = 0;
            dataGridVotos.RowCount = 5;
            dataGridPartidosVotos.RowCount = 5;
            dataGridGanadores.RowCount = 3;
            int primerLugar = 0;
            int segundoLugar = 0;
            int tercerLugar = 0;
            int NI = 0;
            int GANA = 0;
            int ARENA = 0;
            int FMLN = 0;
            int VAMOS = 0;
            
            for (int i = 0; i < votos.GetLength(0); i++)
            {
                for (int j = 0; j < votos.GetLength(1); j++)
                {
                   dataGridVotos.Rows[i].Cells[j].Value = votos[i, j].ToString();

                   dataGridTotalVotos.Rows[0].Cells[0].Value= (totalVotos += votos[i, j]).ToString();

                    NI += votos[0, j];
                    GANA+= votos[1, j];
                    ARENA += votos[2, j];
                    FMLN += votos[3, j];
                    VAMOS += votos[4, j];
                    int[] votosPartidos = {NI,GANA,ARENA,FMLN,VAMOS};
                    dataGridPartidosVotos.Rows.Add(votosPartidos[i].ToString());

                    if (NI > primerLugar)
                    {
                        primerLugar = NI;
                        dataGridGanadores.Rows[0].Cells[0].Value = "NI";
                        dataGridGanadores.Rows[0].Cells[1].Value = NI;

                    }
                    if (GANA > primerLugar)
                    {
                        primerLugar = GANA;
                        dataGridGanadores.Rows[0].Cells[0].Value = "GANA";
                        dataGridGanadores.Rows[0].Cells[1].Value = GANA;
                    }
                    if (ARENA > primerLugar)
                    {
                        primerLugar = ARENA;
                        dataGridGanadores.Rows[0].Cells[0].Value = "ARENA";
                        dataGridGanadores.Rows[0].Cells[1].Value = ARENA;
                    }
                    if (FMLN > primerLugar)
                    {
                        primerLugar = FMLN;
                        dataGridGanadores.Rows[0].Cells[0].Value = "FMLN";
                        dataGridGanadores.Rows[0].Cells[1].Value = FMLN;
                    }
                    if (VAMOS > primerLugar)
                    {
                        primerLugar = VAMOS;
                        dataGridGanadores.Rows[0].Cells[0].Value = "VAMOS";
                        dataGridGanadores.Rows[0].Cells[1].Value = VAMOS;
                    }

                    if (NI > segundoLugar &&NI <primerLugar)
                    {
                        segundoLugar = NI;
                        dataGridGanadores.Rows[1].Cells[0].Value = "NI";
                        dataGridGanadores.Rows[1].Cells[1].Value = NI;

                    }
                    if (GANA > segundoLugar && GANA < primerLugar)
                    {
                        segundoLugar = GANA;
                        dataGridGanadores.Rows[1].Cells[0].Value = "GANA";
                        dataGridGanadores.Rows[1].Cells[1].Value = GANA;
                    }
                    if (ARENA > segundoLugar && ARENA < primerLugar)
                    {
                        segundoLugar = ARENA;
                        dataGridGanadores.Rows[1].Cells[0].Value = "ARENA";
                        dataGridGanadores.Rows[1].Cells[1].Value = ARENA;
                    }
                    if (FMLN > segundoLugar && FMLN < primerLugar)
                    {
                        segundoLugar = FMLN;
                        dataGridGanadores.Rows[1].Cells[0].Value = "FMLN";
                        dataGridGanadores.Rows[1].Cells[1].Value = FMLN;
                    }
                    if (VAMOS > segundoLugar && VAMOS < primerLugar)
                    {
                        segundoLugar = VAMOS;
                        dataGridGanadores.Rows[1].Cells[0].Value = "VAMOS";
                        dataGridGanadores.Rows[1].Cells[1].Value = VAMOS;
                    }


                    if (NI < segundoLugar)
                    {
                        tercerLugar = NI;
                        dataGridGanadores.Rows[2].Cells[0].Value = "NI";
                        dataGridGanadores.Rows[2].Cells[1].Value = NI;

                    }
                    if (GANA < segundoLugar)
                    {
                        tercerLugar = GANA;
                        dataGridGanadores.Rows[2].Cells[0].Value = "GANA";
                        dataGridGanadores.Rows[2].Cells[1].Value = GANA;
                    }
                    if (ARENA < segundoLugar)
                    {
                        tercerLugar = ARENA;
                        dataGridGanadores.Rows[2].Cells[0].Value = "ARENA";
                        dataGridGanadores.Rows[2].Cells[1].Value = ARENA;
                    }
                    if (FMLN < segundoLugar)
                    {
                        tercerLugar = FMLN;
                        dataGridGanadores.Rows[2].Cells[0].Value = "FMLN";
                        dataGridGanadores.Rows[2].Cells[1].Value = FMLN;
                    }
                    if (VAMOS < segundoLugar)
                    {
                        tercerLugar = VAMOS;
                        dataGridGanadores.Rows[2].Cells[0].Value = "VAMOS";
                        dataGridGanadores.Rows[2].Cells[1].Value = VAMOS;
                    }
                }
                   
            }
          
        }
    }
}

