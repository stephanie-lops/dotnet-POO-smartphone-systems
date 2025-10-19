# DIO - .NET Track - Object-Oriented Programming  
www.dio.me  

## Project Challenge  
In this challenge, I put into practice the knowledge I acquired in the **Object-Oriented Programming** module of DIO’s .NET track.  

## Context  
I was responsible for modeling a system that works with mobile phones.  
My goal was to create a **cell phone abstraction**, allowing different brands and models to have their own behaviors, promoting **code reuse** and applying **Object-Oriented Programming** concepts.  

## Proposal  
I developed a **.NET Console** system with an abstract class called `Smartphone` and specific classes for two phone types: **Nokia** and **iPhone**.  
I followed the diagram below to structure my classes:  

![Class diagram](Images/diagram.png)  

## Rules and Validations  
1. The **Smartphone** class is abstract — it serves only as a model and cannot be instantiated directly.  
2. The **Nokia** and **iPhone** classes inherit from **Smartphone**.  
3. The **InstallApp** method is overridden in each subclass, respecting the specific behavior of each brand.  

## My Solution  
I implemented all classes according to the diagram, ensuring:  
- Constructors initialize the common properties (`Number`, `Model`, and `IMEI`).  
- Methods for making and receiving calls (`Call` and `ReceiveCall`).  
- Overridden `InstallApp` methods for each model, simulating app installation through each brand’s specific store.  




# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de Projeto
Neste desafio, coloquei em prática meus conhecimentos adquiridos no módulo de **Orientação a Objetos** da trilha .NET da DIO.

## Contexto
Fui responsável por modelar um sistema que trabalha com celulares. Meu objetivo foi criar uma **abstração de celular**, permitindo que diferentes marcas e modelos tivessem comportamentos próprios, promovendo **reuso de código** e aplicando os conceitos de **Orientação a Objetos**.

## Proposta
Desenvolvi um sistema em **.NET Console**, com uma classe abstrata `Smartphone` e classes específicas para dois tipos de celulares: **Nokia** e **iPhone**.  
Segui o diagrama abaixo para estruturar minhas classes:

![Diagrama classes](Imagens/diagrama.png)

## Regras e Validações
1. A classe **Smartphone** é abstrata, servindo apenas como modelo e não permitindo instância direta.
2. As classes **Nokia** e **Iphone** herdam de **Smartphone**.
3. O método **InstalarAplicativo** é sobrescrito em cada classe filha, respeitando o comportamento específico de cada marca.

## Minha Solução
Implementei todas as classes de acordo com o diagrama, garantindo:  
- Construtores que inicializam as propriedades comuns (`Número`, `Modelo` e `IMEI`).  
- Métodos de ligação (`Ligar` e `ReceberLigacao`).  
- Sobrescrita de `InstalarAplicativo` para cada modelo, simulando a instalação de aplicativos em lojas específicas de cada marca.