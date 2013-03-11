using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace practica3
{
    public class Programa
    {
      private Hashtable tabla;

		public Programa(){
			this.tabla = new Hashtable();
		}

		public void capturar(){
			for(int i = 0; i<4 ;i++){
				Console.Clear();
				this.capturardatosPersona(new Persona());
			}
		}

		private void capturardatosPersona(Persona persona){
			this.capturardatos(persona);
			this.agregarPersona(persona);

		}

		private void capturardatos(Persona persona){
			Console.WriteLine(" Datos de la persona");
			if(persona.codigo == ""){
				Console.WriteLine("Dame el código");
				persona.codigo = Console.ReadLine();
			}

			Console.WriteLine("Dame tu nombre");
			persona.nombre = Console.ReadLine();
            Console.WriteLine("Dame tu apelldo");
            persona.apellidos = Console.ReadLine();
			Console.WriteLine("Dame tu dirección");
			persona.direccion = Console.ReadLine();
			Console.WriteLine("Dame tu teléfono");
			persona.telefono = Console.ReadLine();
			Console.WriteLine("Dame tu facebook");
			persona.facebook = Console.ReadLine();
		}

		private void agregarPersona(Persona persona){			
			if(this.tabla.ContainsKey(persona.codigo)){
				this.tabla.Remove(persona.codigo);
			}

			this.tabla.Add(persona.codigo,persona);
		}

		public void editar(){
			for(int i = 0; i < 2; i++){
				Console.Clear();
				string codigo = "";
				Console.WriteLine("Dame el código para editar");
				codigo = Console.ReadLine();
				if(this.tabla.ContainsKey(codigo)){
					Persona persona = (Persona)this.tabla[codigo];
					this.imprimePersona(persona);
					this.capturardatosPersona(persona);
				}
                else{
				
                    this.imprimeError();
				
                }
			
            }
		}


		public void eliminar(){
			for(int i = 0; i < 2; i++){
				Console.Clear();
				string codigo = "";
				Console.WriteLine("Dame el código para eliminar");
				codigo = Console.ReadLine();
				if(this.tabla.ContainsKey(codigo)){
					Persona persona = (Persona) this.tabla[codigo];
					this.imprimePersona(persona);
					this.confirmarEliminacionYEliminar(persona.codigo);
				}
                else{
					this.imprimeError();
				}
			}
		}

		private void confirmarEliminacionYEliminar(string codigo){
			Console.WriteLine("¿Esta seguro que desea eliminar?");
			Console.WriteLine("0 = No, 1 = Si");
			string opcion = Console.ReadLine();
			if(opcion != "0"){
				this.tabla.Remove(codigo);
			}
		}

		private void imprimeError(){
			Console.WriteLine("No existe el código.");
			Console.WriteLine("Presione cualquier tecla para continuar.");
			Console.ReadLine();
		}

		public void imprimirTodos(){
	        ICollection personas = this.tabla.Values;
            Console.WriteLine();
	        foreach( object objeto in personas )
	        {
	            Persona persona = (Persona) objeto;
				this.imprimePersona(persona);
	        }
		}

		private void imprimePersona(Persona persona){
			Console.WriteLine("Código: " + persona.codigo);
			Console.WriteLine("Nombre: " + persona.nombre);
			Console.WriteLine("Dirección: " + persona.direccion);
			Console.WriteLine("Teléfono: " + persona.telefono);
			Console.WriteLine("Facebook: " + persona.facebook);
			Console.WriteLine("");
		}



    }
}
