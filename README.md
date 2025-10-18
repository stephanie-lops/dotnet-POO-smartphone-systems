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