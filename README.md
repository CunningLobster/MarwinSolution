# MarwinSolution
Тестовое задание на должность Разработчик C# в компанию Меломан
## Инструкция по запуску
Перед запуском необходимо настроить строку подключения к серверу MS SQL серверу. 
Вконфигурационном файле по адресу `MarwinSolution/Marwin.UI/App.config` необходимо внести следующие изменения:
```
﻿<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
    <add name="DefaultConnectionString"
    connectionString="Data Source=<ВВЕСТИ АДРЕС MS SQL СЕРВЕРА>;Initial Catalog=MarwinDB;Integrated Security=True;Connect Timeout=30"
    providerName="System.Data.SqlClient"/>
  </connectionStrings>
</configuration>
```
Во время запуска будет создана база данных с названием MarwinDB на выбранном сервере.

## Пример валидного CSV файла для загрузки сотрудников в компанию
```
FirstName,LastName,ThirdName,TIN
Yuma,Marzella,Joiner,429807226699
Beitris,Whaley,Streight,965551236197
Kacy,Holbury,Staning,570138793767
Jamie,Pauncefort,Towsie,734415387799
```
