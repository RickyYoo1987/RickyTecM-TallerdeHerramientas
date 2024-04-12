# RickyTecM-TallerdeHerramientas
Este repositorio comprende la creación de un código para una empresa.

#  Proyecto de control y migración de PSTs

#Problema

Durante el proyecto de migración de archivos tipo PST hacia la nube, yo Ricardo Moreno, Ingeniero relacionado con esta proyecto, he detectado que los PSTs toman mucho tiempo de carga y generan confusión ya que los nombres que los usuarios denominan a sus archivos es muy genérico y tiende a repertirse en patrones.

#  Solución propuesta

Para tal efecto, mi propuesta es renombrar los archivos de manera única, utilizando el siguiente formato:

"smtp" + "_" + "Nombre del PST"

Ejemplo

Castillo.RicardoM@ricardolabs.info_ElProfesorDarioEsMuyProfesional.pst

#  Arquitectura

Para tal efecto, se requiere:

1.- Servidores Windows con consola de Scripting (mejor conocida como PowerShell ISE). 2.- Servidores de carga Azure tipo Blob 3.- Cuentas de acceso con rol "BlobContributor" o si no es posible, instalación del software AZCopy.exe
Requerimientos

A.- Servidor Windows preferentemente mayor a 2012 B.- Acceso Blobs de Azure C.- Cuentas con privilegios.

#  Configuración

Leer el archivo Config.txt

#  Uso / Contribución

Si deseas colaborar con más ideas para este código puedes hacerlo a través de una una branch llamada develop.

#  Ligas de Utilidad:

https://learn.microsoft.com/en-us/purview/use-network-upload-to-import-pst-files

https://ricardolabs.sharepoint.com/sites/Tallerdeproductividadbasadaenherramientastecnolgicas

#  Para consultar la liga donde ver un vídeo de demostración:

https://utmedu-my.sharepoint.com/:v:/g/personal/al03003446_tecmilenio_mx/EXTcn1vzeMlPhmXGDpxfzl4B8Mc5n_80qnSqU4RXRTN56w?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJTdHJlYW1XZWJBcHAiLCJyZWZlcnJhbFZpZXciOiJTaGFyZURpYWxvZyIsInJlZmVycmFsQXBwUGxhdGZvcm0iOiJXZWIiLCJyZWZlcnJhbE1vZGUiOiJ2aWV3In19&e=J78sbO

