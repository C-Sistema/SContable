﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Contable : DbContext
    {
        public Contable()
            : base("name=Contable")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ajusxbanc> ajusxbanc { get; set; }
        public virtual DbSet<ajusxlote> ajusxlote { get; set; }
        public virtual DbSet<banco> banco { get; set; }
        public virtual DbSet<bitacora> bitacora { get; set; }
        public virtual DbSet<boton> boton { get; set; }
        public virtual DbSet<caja> caja { get; set; }
        public virtual DbSet<Cambio> Cambio { get; set; }
        public virtual DbSet<catexcheq> catexcheq { get; set; }
        public virtual DbSet<cheque> cheque { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<configuracion> configuracion { get; set; }
        public virtual DbSet<confxpart> confxpart { get; set; }
        public virtual DbSet<cuenxcobr> cuenxcobr { get; set; }
        public virtual DbSet<cuenxpaga> cuenxpaga { get; set; }
        public virtual DbSet<descxcheq> descxcheq { get; set; }
        public virtual DbSet<detaxpart> detaxpart { get; set; }
        public virtual DbSet<detaxvent> detaxvent { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<formapago> formapago { get; set; }
        public virtual DbSet<gastxviaj> gastxviaj { get; set; }
        public virtual DbSet<histxbanc> histxbanc { get; set; }
        public virtual DbSet<histxcajac> histxcajac { get; set; }
        public virtual DbSet<liquidacion> liquidacion { get; set; }
        public virtual DbSet<lote> lote { get; set; }
        public virtual DbSet<lotexbanc> lotexbanc { get; set; }
        public virtual DbSet<memorando> memorando { get; set; }
        public virtual DbSet<modulo> modulo { get; set; }
        public virtual DbSet<moneda> moneda { get; set; }
        public virtual DbSet<nomenclatura> nomenclatura { get; set; }
        public virtual DbSet<pagoxclie> pagoxclie { get; set; }
        public virtual DbSet<pagoxprov> pagoxprov { get; set; }
        public virtual DbSet<partida> partida { get; set; }
        public virtual DbSet<presentacion> presentacion { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<tamano> tamano { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<venta> venta { get; set; }
        public virtual DbSet<viaje> viaje { get; set; }
        public virtual DbSet<detaxpaxpr> detaxpaxpr { get; set; }
    
        public virtual ObjectResult<pac_bitacora_1_Result> pac_bitacora_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_bitacora_1_Result>("pac_bitacora_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_boton_1_Result> pac_boton_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_boton_1_Result>("pac_boton_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_boton_2_Result> pac_boton_2(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_boton_2_Result>("pac_boton_2", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_cliente_1_Result> pac_cliente_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_cliente_1_Result>("pac_cliente_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_cliente_2_Result> pac_cliente_2(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_cliente_2_Result>("pac_cliente_2", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_consulta_Result> pac_consulta(string para0)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_consulta_Result>("pac_consulta", para0Parameter);
        }
    
        public virtual ObjectResult<pac_empleado_1_Result> pac_empleado_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_empleado_1_Result>("pac_empleado_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_empleado_2_Result> pac_empleado_2(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_empleado_2_Result>("pac_empleado_2", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_modulo_1_Result> pac_modulo_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_modulo_1_Result>("pac_modulo_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_modulo_2_Result> pac_modulo_2(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_modulo_2_Result>("pac_modulo_2", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual int pac_permiso_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pac_permiso_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_proveedor_1_Result> pac_proveedor_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_proveedor_1_Result>("pac_proveedor_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_proveedor_2_Result> pac_proveedor_2(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_proveedor_2_Result>("pac_proveedor_2", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_rol_1_Result> pac_rol_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_rol_1_Result>("pac_rol_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_rol_2_Result> pac_rol_2(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_rol_2_Result>("pac_rol_2", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_usuario_1_Result> pac_usuario_1(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_usuario_1_Result>("pac_usuario_1", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_usuario_2_Result> pac_usuario_2(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_usuario_2_Result>("pac_usuario_2", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual ObjectResult<pac_usuario_3_Result> pac_usuario_3(string para0, string para1, string para2, string para3)
        {
            var para0Parameter = para0 != null ?
                new ObjectParameter("para0", para0) :
                new ObjectParameter("para0", typeof(string));
    
            var para1Parameter = para1 != null ?
                new ObjectParameter("para1", para1) :
                new ObjectParameter("para1", typeof(string));
    
            var para2Parameter = para2 != null ?
                new ObjectParameter("para2", para2) :
                new ObjectParameter("para2", typeof(string));
    
            var para3Parameter = para3 != null ?
                new ObjectParameter("para3", para3) :
                new ObjectParameter("para3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pac_usuario_3_Result>("pac_usuario_3", para0Parameter, para1Parameter, para2Parameter, para3Parameter);
        }
    
        public virtual int pam_bitacora(Nullable<byte> accion, Nullable<int> idx_bit, string tabla_bit, string modulo_bit, string area_bit, string accion_bit, string detalle_bit, Nullable<System.DateTime> fecha_bit, Nullable<int> idx_emp)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var idx_bitParameter = idx_bit.HasValue ?
                new ObjectParameter("idx_bit", idx_bit) :
                new ObjectParameter("idx_bit", typeof(int));
    
            var tabla_bitParameter = tabla_bit != null ?
                new ObjectParameter("tabla_bit", tabla_bit) :
                new ObjectParameter("tabla_bit", typeof(string));
    
            var modulo_bitParameter = modulo_bit != null ?
                new ObjectParameter("modulo_bit", modulo_bit) :
                new ObjectParameter("modulo_bit", typeof(string));
    
            var area_bitParameter = area_bit != null ?
                new ObjectParameter("area_bit", area_bit) :
                new ObjectParameter("area_bit", typeof(string));
    
            var accion_bitParameter = accion_bit != null ?
                new ObjectParameter("accion_bit", accion_bit) :
                new ObjectParameter("accion_bit", typeof(string));
    
            var detalle_bitParameter = detalle_bit != null ?
                new ObjectParameter("detalle_bit", detalle_bit) :
                new ObjectParameter("detalle_bit", typeof(string));
    
            var fecha_bitParameter = fecha_bit.HasValue ?
                new ObjectParameter("fecha_bit", fecha_bit) :
                new ObjectParameter("fecha_bit", typeof(System.DateTime));
    
            var idx_empParameter = idx_emp.HasValue ?
                new ObjectParameter("idx_emp", idx_emp) :
                new ObjectParameter("idx_emp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_bitacora", accionParameter, idx_bitParameter, tabla_bitParameter, modulo_bitParameter, area_bitParameter, accion_bitParameter, detalle_bitParameter, fecha_bitParameter, idx_empParameter);
        }
    
        public virtual int pam_boton(Nullable<byte> accion, Nullable<int> id_bot, string nombre_bot, Nullable<byte> posicion_bot, Nullable<int> id_mod, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_botParameter = id_bot.HasValue ?
                new ObjectParameter("id_bot", id_bot) :
                new ObjectParameter("id_bot", typeof(int));
    
            var nombre_botParameter = nombre_bot != null ?
                new ObjectParameter("nombre_bot", nombre_bot) :
                new ObjectParameter("nombre_bot", typeof(string));
    
            var posicion_botParameter = posicion_bot.HasValue ?
                new ObjectParameter("posicion_bot", posicion_bot) :
                new ObjectParameter("posicion_bot", typeof(byte));
    
            var id_modParameter = id_mod.HasValue ?
                new ObjectParameter("id_mod", id_mod) :
                new ObjectParameter("id_mod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_boton", accionParameter, id_botParameter, nombre_botParameter, posicion_botParameter, id_modParameter, ban, res);
        }
    
        public virtual int pam_cliente(Nullable<byte> accion, Nullable<int> id_cli, string nit_cli, string nombre_cli, string apellido_cli, string telefono1_cli, string telefono2_cli, string correo_cli, Nullable<decimal> saldoq_cli, Nullable<decimal> saldoc_cli, Nullable<bool> credito_cli, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_cliParameter = id_cli.HasValue ?
                new ObjectParameter("id_cli", id_cli) :
                new ObjectParameter("id_cli", typeof(int));
    
            var nit_cliParameter = nit_cli != null ?
                new ObjectParameter("nit_cli", nit_cli) :
                new ObjectParameter("nit_cli", typeof(string));
    
            var nombre_cliParameter = nombre_cli != null ?
                new ObjectParameter("nombre_cli", nombre_cli) :
                new ObjectParameter("nombre_cli", typeof(string));
    
            var apellido_cliParameter = apellido_cli != null ?
                new ObjectParameter("apellido_cli", apellido_cli) :
                new ObjectParameter("apellido_cli", typeof(string));
    
            var telefono1_cliParameter = telefono1_cli != null ?
                new ObjectParameter("telefono1_cli", telefono1_cli) :
                new ObjectParameter("telefono1_cli", typeof(string));
    
            var telefono2_cliParameter = telefono2_cli != null ?
                new ObjectParameter("telefono2_cli", telefono2_cli) :
                new ObjectParameter("telefono2_cli", typeof(string));
    
            var correo_cliParameter = correo_cli != null ?
                new ObjectParameter("correo_cli", correo_cli) :
                new ObjectParameter("correo_cli", typeof(string));
    
            var saldoq_cliParameter = saldoq_cli.HasValue ?
                new ObjectParameter("saldoq_cli", saldoq_cli) :
                new ObjectParameter("saldoq_cli", typeof(decimal));
    
            var saldoc_cliParameter = saldoc_cli.HasValue ?
                new ObjectParameter("saldoc_cli", saldoc_cli) :
                new ObjectParameter("saldoc_cli", typeof(decimal));
    
            var credito_cliParameter = credito_cli.HasValue ?
                new ObjectParameter("credito_cli", credito_cli) :
                new ObjectParameter("credito_cli", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_cliente", accionParameter, id_cliParameter, nit_cliParameter, nombre_cliParameter, apellido_cliParameter, telefono1_cliParameter, telefono2_cliParameter, correo_cliParameter, saldoq_cliParameter, saldoc_cliParameter, credito_cliParameter, ban, res);
        }
    
        public virtual int pam_empleado(Nullable<byte> accion, Nullable<int> id_emp, string nombre_emp, string apellido_emp, string cui_emp, Nullable<System.DateTime> fechai_emp, Nullable<System.DateTime> fechaf_emp, string direccion_emp, string telefono_emp, string telefono2_emp, string correo_emp, Nullable<int> id_rol, Nullable<int> idx_emp, Nullable<System.DateTime> fecha_bit, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_empParameter = id_emp.HasValue ?
                new ObjectParameter("id_emp", id_emp) :
                new ObjectParameter("id_emp", typeof(int));
    
            var nombre_empParameter = nombre_emp != null ?
                new ObjectParameter("nombre_emp", nombre_emp) :
                new ObjectParameter("nombre_emp", typeof(string));
    
            var apellido_empParameter = apellido_emp != null ?
                new ObjectParameter("apellido_emp", apellido_emp) :
                new ObjectParameter("apellido_emp", typeof(string));
    
            var cui_empParameter = cui_emp != null ?
                new ObjectParameter("cui_emp", cui_emp) :
                new ObjectParameter("cui_emp", typeof(string));
    
            var fechai_empParameter = fechai_emp.HasValue ?
                new ObjectParameter("fechai_emp", fechai_emp) :
                new ObjectParameter("fechai_emp", typeof(System.DateTime));
    
            var fechaf_empParameter = fechaf_emp.HasValue ?
                new ObjectParameter("fechaf_emp", fechaf_emp) :
                new ObjectParameter("fechaf_emp", typeof(System.DateTime));
    
            var direccion_empParameter = direccion_emp != null ?
                new ObjectParameter("direccion_emp", direccion_emp) :
                new ObjectParameter("direccion_emp", typeof(string));
    
            var telefono_empParameter = telefono_emp != null ?
                new ObjectParameter("telefono_emp", telefono_emp) :
                new ObjectParameter("telefono_emp", typeof(string));
    
            var telefono2_empParameter = telefono2_emp != null ?
                new ObjectParameter("telefono2_emp", telefono2_emp) :
                new ObjectParameter("telefono2_emp", typeof(string));
    
            var correo_empParameter = correo_emp != null ?
                new ObjectParameter("correo_emp", correo_emp) :
                new ObjectParameter("correo_emp", typeof(string));
    
            var id_rolParameter = id_rol.HasValue ?
                new ObjectParameter("id_rol", id_rol) :
                new ObjectParameter("id_rol", typeof(int));
    
            var idx_empParameter = idx_emp.HasValue ?
                new ObjectParameter("idx_emp", idx_emp) :
                new ObjectParameter("idx_emp", typeof(int));
    
            var fecha_bitParameter = fecha_bit.HasValue ?
                new ObjectParameter("fecha_bit", fecha_bit) :
                new ObjectParameter("fecha_bit", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_empleado", accionParameter, id_empParameter, nombre_empParameter, apellido_empParameter, cui_empParameter, fechai_empParameter, fechaf_empParameter, direccion_empParameter, telefono_empParameter, telefono2_empParameter, correo_empParameter, id_rolParameter, idx_empParameter, fecha_bitParameter, ban, res);
        }
    
        public virtual int pam_modulo(Nullable<byte> accion, Nullable<int> id_mod, string nombre_mod, Nullable<byte> posicion_mod, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_modParameter = id_mod.HasValue ?
                new ObjectParameter("id_mod", id_mod) :
                new ObjectParameter("id_mod", typeof(int));
    
            var nombre_modParameter = nombre_mod != null ?
                new ObjectParameter("nombre_mod", nombre_mod) :
                new ObjectParameter("nombre_mod", typeof(string));
    
            var posicion_modParameter = posicion_mod.HasValue ?
                new ObjectParameter("posicion_mod", posicion_mod) :
                new ObjectParameter("posicion_mod", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_modulo", accionParameter, id_modParameter, nombre_modParameter, posicion_modParameter, ban, res);
        }
    
        public virtual int pam_permiso(Nullable<byte> accion, Nullable<int> id_usu, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_usuParameter = id_usu.HasValue ?
                new ObjectParameter("id_usu", id_usu) :
                new ObjectParameter("id_usu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_permiso", accionParameter, id_usuParameter, ban, res);
        }
    
        public virtual int pam_proveedor(Nullable<byte> accion, Nullable<int> id_pro, string nombre_pro, string direccion_pro, string cp_pro, string telefono1_pro, string telefono2_pro, string rfiscal_pro, Nullable<decimal> saldoq_pro, Nullable<decimal> saldod_pro, string extra_pro, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_proParameter = id_pro.HasValue ?
                new ObjectParameter("id_pro", id_pro) :
                new ObjectParameter("id_pro", typeof(int));
    
            var nombre_proParameter = nombre_pro != null ?
                new ObjectParameter("nombre_pro", nombre_pro) :
                new ObjectParameter("nombre_pro", typeof(string));
    
            var direccion_proParameter = direccion_pro != null ?
                new ObjectParameter("direccion_pro", direccion_pro) :
                new ObjectParameter("direccion_pro", typeof(string));
    
            var cp_proParameter = cp_pro != null ?
                new ObjectParameter("cp_pro", cp_pro) :
                new ObjectParameter("cp_pro", typeof(string));
    
            var telefono1_proParameter = telefono1_pro != null ?
                new ObjectParameter("telefono1_pro", telefono1_pro) :
                new ObjectParameter("telefono1_pro", typeof(string));
    
            var telefono2_proParameter = telefono2_pro != null ?
                new ObjectParameter("telefono2_pro", telefono2_pro) :
                new ObjectParameter("telefono2_pro", typeof(string));
    
            var rfiscal_proParameter = rfiscal_pro != null ?
                new ObjectParameter("rfiscal_pro", rfiscal_pro) :
                new ObjectParameter("rfiscal_pro", typeof(string));
    
            var saldoq_proParameter = saldoq_pro.HasValue ?
                new ObjectParameter("saldoq_pro", saldoq_pro) :
                new ObjectParameter("saldoq_pro", typeof(decimal));
    
            var saldod_proParameter = saldod_pro.HasValue ?
                new ObjectParameter("saldod_pro", saldod_pro) :
                new ObjectParameter("saldod_pro", typeof(decimal));
    
            var extra_proParameter = extra_pro != null ?
                new ObjectParameter("extra_pro", extra_pro) :
                new ObjectParameter("extra_pro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_proveedor", accionParameter, id_proParameter, nombre_proParameter, direccion_proParameter, cp_proParameter, telefono1_proParameter, telefono2_proParameter, rfiscal_proParameter, saldoq_proParameter, saldod_proParameter, extra_proParameter, ban, res);
        }
    
        public virtual int pam_rol(Nullable<byte> accion, Nullable<int> id_rol, string nombre_rol, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_rolParameter = id_rol.HasValue ?
                new ObjectParameter("id_rol", id_rol) :
                new ObjectParameter("id_rol", typeof(int));
    
            var nombre_rolParameter = nombre_rol != null ?
                new ObjectParameter("nombre_rol", nombre_rol) :
                new ObjectParameter("nombre_rol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_rol", accionParameter, id_rolParameter, nombre_rolParameter, ban, res);
        }
    
        public virtual int pam_usuario(Nullable<byte> accion, Nullable<int> id_usu, string nombre_usu, string contrasena_usu, string contrasenavieja_usu, Nullable<int> id_emp, Nullable<bool> permxpers_usu, Nullable<int> idx_emp, Nullable<System.DateTime> fecha_bit, ObjectParameter ban, ObjectParameter res)
        {
            var accionParameter = accion.HasValue ?
                new ObjectParameter("accion", accion) :
                new ObjectParameter("accion", typeof(byte));
    
            var id_usuParameter = id_usu.HasValue ?
                new ObjectParameter("id_usu", id_usu) :
                new ObjectParameter("id_usu", typeof(int));
    
            var nombre_usuParameter = nombre_usu != null ?
                new ObjectParameter("nombre_usu", nombre_usu) :
                new ObjectParameter("nombre_usu", typeof(string));
    
            var contrasena_usuParameter = contrasena_usu != null ?
                new ObjectParameter("contrasena_usu", contrasena_usu) :
                new ObjectParameter("contrasena_usu", typeof(string));
    
            var contrasenavieja_usuParameter = contrasenavieja_usu != null ?
                new ObjectParameter("contrasenavieja_usu", contrasenavieja_usu) :
                new ObjectParameter("contrasenavieja_usu", typeof(string));
    
            var id_empParameter = id_emp.HasValue ?
                new ObjectParameter("id_emp", id_emp) :
                new ObjectParameter("id_emp", typeof(int));
    
            var permxpers_usuParameter = permxpers_usu.HasValue ?
                new ObjectParameter("permxpers_usu", permxpers_usu) :
                new ObjectParameter("permxpers_usu", typeof(bool));
    
            var idx_empParameter = idx_emp.HasValue ?
                new ObjectParameter("idx_emp", idx_emp) :
                new ObjectParameter("idx_emp", typeof(int));
    
            var fecha_bitParameter = fecha_bit.HasValue ?
                new ObjectParameter("fecha_bit", fecha_bit) :
                new ObjectParameter("fecha_bit", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pam_usuario", accionParameter, id_usuParameter, nombre_usuParameter, contrasena_usuParameter, contrasenavieja_usuParameter, id_empParameter, permxpers_usuParameter, idx_empParameter, fecha_bitParameter, ban, res);
        }
    }
}
