using System;

namespace PremiosOscar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Evento evento1 = new Evento(2);
            evento1.entregaDePremios();
            evento1.mostrarEvento();

            Console.WriteLine("#######################################");
            Console.WriteLine("#######         INCISO A        #######");
            Console.WriteLine("#######################################");
            int anio = 2020;
            //this.anio=int.Parse(Console.ReadLine());
            evento1.mostrarMejorMusicalizacion(anio);

            Console.WriteLine("#######################################");
            Console.WriteLine("#######         INCISO B        #######");
            Console.WriteLine("#######################################");

            evento1.eliminarMenorArgumento();

            Console.WriteLine("#######################################");
            Console.WriteLine("#######         INCISO C        #######");
            Console.WriteLine("#######################################");

            evento1.verificarJurado("nelson", 8.5);



        }
    }
    // ###########################################

    public class Valoracion <W,T,Z>
    {
        int nroJurados;
        String[] jurados = new String[20];
        W valoracionMusical ;
        T valoracionActuacion;
        Z valoracionArgumento;

        public Valoracion(int nroJurados,/* String[] jurados,*/ W valoracionMusical, T valoracionActuacion, Z valoracionArgumento){
            this.nroJurados             = nroJurados;
            //this.jurados                = jurados;
            this.valoracionMusical      = valoracionMusical;
            this.valoracionActuacion    = valoracionActuacion;
            this.valoracionArgumento    = valoracionArgumento;

            //  creamos una lista de jurados por defecto
            //  esta lista podria ser llenada manualmente pero por fines de la practica lo realizaremos por defecto
            String[] juradosPreList = new String[]{"alejandro","daniel","carmen","julio","nelson","vladimir","eliel","carla","sandra","alejandro otra vez"};
            
            for(int i = 0; i < this.nroJurados; i++){
                this.jurados[i]=juradosPreList[i];
            }
        }

        public void mostrarValoracion(){
            Console.WriteLine("Los jurados que participaron son: ");
            for(int i=0; i<this.nroJurados;i++){
                Console.WriteLine(" - {0}",this.jurados[i]);
            }
            Console.WriteLine("La valoracion Musical es de: {0}",this.valoracionMusical);
            Console.WriteLine("La valoracion de Actuacion es de: {0}",this.valoracionActuacion);
            Console.WriteLine("La valoracion de Argumento es de: {0}",this.valoracionArgumento);
        }

        public void eliminar(){
            this.nroJurados             = 0;
            this.jurados                = new String[nroJurados];
            //this.valoracionMusical      = null;
            //this.valoracionActuacion    = null;
            //this.valoracionArgumento    = null;
        }

        public W getValoracionMusical(){
            return this.valoracionMusical;
        }
        public Z getValoracionArgumento(){
            return this.valoracionArgumento;
        }

        public T getActuacion(){
            return this.valoracionActuacion;
        }

        public bool getNombreJurado(String x){
            for(int i=0; i<this.nroJurados;i++){
                if(jurados[i].Equals(x)){
                    return true;
                }
            }
            return false;
        }

        
    }

    //#############################################

    public class Premio
    {
        int anio;
        int nroPeliculas;
        String[] peliculas = new String[20];
        Valoracion<double, double, double>[] valoracion = new Valoracion<double, double, double>[20];

        public Premio(int anio, int nroPeliculas){
            this.anio           = anio;
            this.nroPeliculas   = nroPeliculas;
        }

        public int getanio(){
            return this.anio;
        }

        public void llenarPremiacion(){


            // en esta funcion se llenaria las peliculas
            // en caso de que se quiera llenar manualmente se debera poner una funcion de llenado y lectura
            // para esta practica usaremos la siguiente lista pre establecida
            String[] pelisPrelista = new String[]{"Los vengadores","Cars 2", "Los Increibles", "Los teletubies", "Las tortugas ninjas", "Yo despues de ti", "Diario de una pasion","CharlesChaplin","En busca de la felicidad","Chapie","Siempre a tu lado","Hachico nooooo"};

            for(int i = 0; i<this.nroPeliculas; i++){
                this.peliculas[i] = pelisPrelista[i];
            }
            // asignamos las valoraciones correspondientes primeramente creando una preEstablecida
            // esto podria hacerce manualmente pero por fines de la practica lo hacemos preEcha
                Valoracion<double, double, double> valoracionPeli1;         valoracionPeli1 = new Valoracion<double, double, double>(5, 7.2,8.5,7.0);
                Valoracion<double, double, double> valoracionPeli2;         valoracionPeli2 = new Valoracion<double, double, double>(3, 3.2,9.5,1.0);
                Valoracion<double, double, double> valoracionPeli3;         valoracionPeli3 = new Valoracion<double, double, double>(5, 8.2,8.5,8.0);
                Valoracion<double, double, double> valoracionPeli4;         valoracionPeli4 = new Valoracion<double, double, double>(3, 4.2,1.5,3.0);
                Valoracion<double, double, double> valoracionPeli5;         valoracionPeli5 = new Valoracion<double, double, double>(5, 6.2,8.5,7.0);
                Valoracion<double, double, double> valoracionPeli6;         valoracionPeli6 = new Valoracion<double, double, double>(3, 9.2,2.5,9.0);
                Valoracion<double, double, double> valoracionPeli7;         valoracionPeli7 = new Valoracion<double, double, double>(5, 0.2,8.5,2.0);
                Valoracion<double, double, double> valoracionPeli8;         valoracionPeli8 = new Valoracion<double, double, double>(3, 5.2,3.5,9.0);
                Valoracion<double, double, double> valoracionPeli9;         valoracionPeli9 = new Valoracion<double, double, double>(5, 2.2,8.5,5.0);
                Valoracion<double, double, double> valoracionPeli10;        valoracionPeli10 = new Valoracion<double, double, double>(3, 9.2,6.5,3.0);
                Valoracion<double, double, double> valoracionPeli11;        valoracionPeli11 = new Valoracion<double, double, double>(5, 5.2,8.5,4.0);
                Valoracion<double, double, double> valoracionPeli12;        valoracionPeli12 = new Valoracion<double, double, double>(3, 6.2,5.5,9.0);

                Valoracion<double, double, double>[] valoracionPreList = new Valoracion<double, double, double>[]{valoracionPeli1,valoracionPeli2,valoracionPeli3,valoracionPeli4,valoracionPeli5,valoracionPeli6,valoracionPeli7,valoracionPeli8,valoracionPeli9,valoracionPeli10,valoracionPeli11,valoracionPeli12};

            //
            for(int i = 0; i<this.nroPeliculas; i++){
                this.valoracion[i] = valoracionPreList[i];
            }


        }

        public void mostrarPremiacion(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("\tAño de la premiacion: {0}", this.anio);
            Console.WriteLine("*************************************************");
            Console.WriteLine("Las peliculas son: ");
            
            for(int i = 0; i<this.nroPeliculas; i++){
                Console.WriteLine("\n- {0} ",this.peliculas[i]);
                Console.WriteLine("Con los siguientes datos de valoracion: ");
                Console.WriteLine("\t_______________ INICIO DATOS DE VALORACION ___________ ");
                this.valoracion[i].mostrarValoracion();
                Console.WriteLine("\t________________ FIN DATOS DE VALORACION _____________\n");
            }
        }
        public void mostrarPremiacionMejorMusicalizacion(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("\tAño de la premiacion: {0}", this.anio);
            Console.WriteLine("*************************************************");
            Console.WriteLine("La pelicula con mejor musicalizcion es: ");

            double maximo = 0;
            int index = 0;
            
            for(int i = 0; i<this.nroPeliculas; i++){
                double valor = this.valoracion[i].getValoracionMusical();
                if(valor > maximo){
                    maximo = valor;
                    index = i;
                }
            }
                Console.WriteLine("\n- {0} ",this.peliculas[index]);
                Console.WriteLine("Con los siguientes datos de valoracion: ");
                Console.WriteLine("\t_______________ INICIO DATOS DE VALORACION ___________ ");
                this.valoracion[index].mostrarValoracion();
                Console.WriteLine("\t________________ FIN DATOS DE VALORACION _____________\n");


        }

        public void eliminarMenorArgumento(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("\tAño de la premiacion: {0}", this.anio);
            Console.WriteLine("*************************************************");
            Console.WriteLine("Las peliculas son: ");
            
            for(int i = 0; i<this.nroPeliculas; i++){
                double argumento = this.valoracion[i].getValoracionArgumento();
                if(argumento<5.0){
                    this.valoracion[i].eliminar();
                }else{
                    Console.WriteLine("\n- {0} ",this.peliculas[i]);
                    Console.WriteLine("Con los siguientes datos de valoracion: ");
                    Console.WriteLine("\t_______________ INICIO DATOS DE VALORACION ___________ ");
                    this.valoracion[i].mostrarValoracion();
                    Console.WriteLine("\t________________ FIN DATOS DE VALORACION _____________\n");
                }
            }
        }

        public int verificarCalificacion(String nombre, double calificacion){
             for(int i = 0; i<this.nroPeliculas; i++){
                double actuacion = this.valoracion[i].getActuacion();
                bool jurado = this.valoracion[i].getNombreJurado(nombre);

                if(actuacion == calificacion && jurado){
                    Console.WriteLine("### EL JURADO {0} SI CALIFICO CON {1} ",nombre,actuacion);
                    return 1;
                }
            }
            Console.WriteLine("### NO HAY REGISTRO DE QUE ### EL JURADO {0} SI CALIFICO CON {1} ",nombre,calificacion);
            return 0;

        }


    }

    //#############################################
    
    public class Evento
    {
        int nroPremios;
        Premio[] premio = new Premio[20];

        public Evento(int nroPremios){
            this.nroPremios = nroPremios;
        }

        
        public void entregaDePremios(){
            // se llama a esta funcion para entregar premios en un evento

            Premio premio1 = new Premio(2020,5);
            premio1.llenarPremiacion();

            Premio premio2 = new Premio(2019,3);
            premio2.llenarPremiacion();

            Premio premio3 = new Premio(2018,3);
            premio3.llenarPremiacion();

            Premio[] preList = new Premio[]{premio1,premio2,premio3};

            for(int i =0 ; i<this.nroPremios; i++){
                this.premio[i] = preList[i];
            }


        }

        public void mostrarEvento(){
            Console.WriteLine("\t\tMostrando Evento: ");
            
            //Console.WriteLine("########$$$$$$$$$$$#############{0}",this.nroPremios);
            for(int i = 0 ; i<this.nroPremios; i++){
                premio[i].mostrarPremiacion();
            }
        }

        public void mostrarMejorMusicalizacion(int anio){
            Console.WriteLine("\t\tMostrando Evento: ");
            
            //Console.WriteLine("########$$$$$$$$$$$#############{0}",this.nroPremios);
            for(int i = 0 ; i<this.nroPremios; i++){
                int aux = premio[i].getanio();
                if(anio == aux){
                    premio[i].mostrarPremiacionMejorMusicalizacion();
                }
            }
        }

        public void eliminarMenorArgumento(){
            for(int i = 0 ; i<this.nroPremios; i++){
                premio[i].eliminarMenorArgumento();
            }
        }

        public void verificarJurado(String nombre, double puntuacion){
            for(int i = 0 ; i<this.nroPremios; i++){
                int aux = premio[i].verificarCalificacion(nombre,puntuacion);
            }
        }
    }
}
