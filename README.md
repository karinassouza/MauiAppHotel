# 🏨 MauiAppHotel

Aplicação mobile de gestão e reservas de alojamento desenvolvida em **.NET MAUI**, com foco em usabilidade, cálculo dinâmico de estadias e navegação fluida.

---

## 📱 Sobre o Projeto

O **MauiAppHotel** foi desenvolvido como parte das atividades práticas do curso técnico de **Desenvolvimento de Sistemas** da **ETEC**. A aplicação permite que o utilizador selecione diferentes acomodações, defina a quantidade de hóspedes e o período da estadia, calculando automaticamente o valor total com base na diária e no número de dias.

---

## ✨ Funcionalidades

- **Seleção de Acomodação:** Escolha entre diferentes categorias de suítes.
- **Definição de Hóspedes:** Seleção da quantidade de adultos e crianças através de *Steppers*.
- **Período da Estadia:** Seleção de datas de *Check-in* e *Check-out* com *DatePickers*.
- **Cálculo Automático:** Cálculo do valor total considerando a diária dos adultos, crianças e número total de dias.
- **Resumo da Hospedagem:** Ecrã detalhado com a confirmação de todos os dados inseridos.
- **Ecrã Sobre:** Informações sobre a desenvolvedora e a aplicação.

---

## 🛠️ Tecnologias Utilizadas

- **Plataforma:** .NET 10 / .NET MAUI
- **Linguagem:** C#
- **Interface Visual:** XAML
- **IDE:** Visual Studio 2026

---

## 📁 Estrutura do Projeto

```text
MauiAppHotel/
├── Models/
│   ├── Hospedagem.cs
│   └── Quarto.cs
└── Views/
    ├── ContratacaoHospedagem.xaml
    ├── HospedagemContratada.xaml
    └── SobrePage.xaml
