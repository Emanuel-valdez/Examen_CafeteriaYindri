# Práctica – Pedidos de la cafetería "El Buen Sabor"

**Nombre:** Yindri Marielis 
**Matrícula:** 2024-1103

## 1\. Descripción del programa

Aplicación de escritorio en Windows Forms (C#) con un solo formulario (`frmPedidos`) que registra los pedidos de una cafetería y calcula el total a pagar, aplicando descuento, empaque e ITBIS.

## 2\. Datos de entrada

* Cliente y si es cliente frecuente
* Fecha del pedido
* Producto (nombre) y precio, digitados por el usuario
* Cantidad (1 a 20)
* Tamaño: Normal o Grande (+RD$25)
* Porción extra (+RD$30)
* Servicio: Consumir en local o Para llevar (+RD$20)

## 3\. Proceso

1. Precio unitario = precio digitado + 25 si es grande + 30 si lleva porción extra.
2. Total de línea = precio unitario × cantidad. Subtotal = suma de las líneas.
3. Descuento: 10 % del subtotal si el cliente es frecuente.
4. Empaque: RD$20 una sola vez por pedido si el servicio es "Para llevar".
5. Base imponible = subtotal − descuento + empaque.
6. ITBIS = 18 % de la base imponible. Total = base imponible + ITBIS.

## 4\. Salida

* Lista del pedido en columnas (Cant, Producto, Precio, Total)
* Subtotal, descuento, empaque, ITBIS y total a pagar, en formato `RD$ 0.00`

## 5\. Caso de prueba

María Pérez (frecuente); Sándwich 180, cantidad 2, grande = 410; Jugo 120, cantidad 1, con porción extra = 150; para llevar.


## 6\. Capturas de pantalla

**Pantalla inicial**

!\[Pantalla inicial](capturas/captura1.png)

**Caso de prueba calculado**

!\[Caso de prueba](capturas/captura2.png)

