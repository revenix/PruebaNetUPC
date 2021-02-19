# PruebaNetUPC

Cambiar la cadena de conexion correspondiente en el archivo web.config.<br>
<br>
<br>
<body>
  
add name="BDVentaEntities" connectionString="metadata=res://*/Models.DBVenta.csdl|res://*/Models.DBVenta.ssdl|res://*/Models.DBVenta.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=[NOMBRE_SERVIDOR_LOCAL];initial catalog=BDVenta;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient"

</body>
