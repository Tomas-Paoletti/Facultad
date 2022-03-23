/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TP2_EJ1;

/**
 *
 * @author Javier
 */
public class Persona {
    
    private int tipo; //0=alumno 1=docente 2=empleado
    private String nombre;
    private String apellido;
    private String estado_civil;
    private int dni;
    private int año_incorporacion;
    private int num_despacho;
    private String departamento;
    private String seccion;

    Persona() {
        
    }

    /**
     * @return the tipo
     */
    public int getTipo() {
        return tipo;
    }

    /**
     * @param tipo the tipo to set
     */
    public void setTipo(int tipo) {
        this.tipo = tipo;
    }
    
    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /**
     * @return the apellido
     */
    public String getApellido() {
        return apellido;
    }

    /**
     * @param apellido the apellido to set
     */
    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    /**
     * @return the estado_civil
     */
    public String getEstado_civil() {
        return estado_civil;
    }

    /**
     * @param estado_civil the estado_civil to set
     */
    public void setEstado_civil(String estado_civil) {
        this.estado_civil = estado_civil;
    }

    /**
     * @return the dni
     */
    public int getDni() {
        return dni;
    }

    /**
     * @param dni the dni to set
     */
    public void setDni(int dni) {
        this.dni = dni;
    }

    /**
     * @return the año_incorporacion
     */
    public int getAño_incorporacion() {
        return año_incorporacion;
    }

    /**
     * @param año_incorporacion the año_incorporacion to set
     */
    public void setAño_incorporacion(int año_incorporacion) {
        this.año_incorporacion = año_incorporacion;
    }

    /**
     * @return the num_despacho
     */
    public int getNum_despacho() {
        return num_despacho;
    }

    /**
     * @param num_despacho the num_despacho to set
     */
    public void setNum_despacho(int num_despacho) {
        this.num_despacho = num_despacho;
    }

    /**
     * @return the departamento
     */
    public String getDepartamento() {
        return departamento;
    }

    /**
     * @param departamento the departamento to set
     */
    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }

    /**
     * @return the seccion
     */
    public String getSeccion() {
        return seccion;
    }

    /**
     * @param seccion the seccion to set
     */
    public void setSeccion(String seccion) {
        this.seccion = seccion;
    }

    
    
    
    
}
