/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp2_ej2;

/**
 *
 * @author tomia_n55eokc
 */
public class Producto {
    private String Nombre;
    private int Codigo, Stock;

    public Producto(String nombre, int codigo, int stock) {
        this.Nombre = nombre;
        this.Codigo = codigo;
        this.Stock = stock;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public int getCodigo() {
        return Codigo;
    }

    public void setCodigo(int Codigo) {
        this.Codigo = Codigo;
    }

    public int getStock() {
        return Stock;
    }

    public void setStock(int Stock) {
        this.Stock = Stock;
    }
    
    
}
