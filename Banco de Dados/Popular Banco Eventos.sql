

-- Populando BD
  
  -- Tabela pais

INSERT INTO pais (pais_nome)
  VALUES ("Brasil");
  
INSERT INTO pais (pais_nome)
  VALUES ("Paraguaí");
  
INSERT INTO pais (pais_nome)
  VALUES ("Argentina");
  
INSERT INTO pais (pais_nome)
  VALUES ("Uruguai");


  -- Tabela estado

INSERT INTO estado (estado_nome,id_pais)
  VALUES ("Paraná","1");
  
INSERT INTO estado (estado_nome,id_pais)
  VALUES ("Santa Carina","1");
  
INSERT INTO estado (estado_nome,id_pais)
  VALUES ("Rio Grande so Sul","1");
  
INSERT INTO estado (estado_nome,id_pais)
  VALUES ("São Paulo","1");
  
  
  -- Tabela cidade

INSERT INTO cidade (cidade_nome,id_estado)
  VALUES ("Irati","1");
  
INSERT INTO cidade (cidade_nome,id_estado)
  VALUES ("Imbituva","1");
  
INSERT INTO cidade (cidade_nome,id_estado)
  VALUES ("Ponta Grossa","1");
  
INSERT INTO cidade (cidade_nome,id_estado)
  VALUES ("Rebouças","1");


  -- Tabela bairro

INSERT INTO bairro (bairro_nome,id_cidade)
  VALUES ("Alto da Glória","1");
  
INSERT INTO bairro (bairro_nome,id_cidade)
  VALUES ("Centro","2");
  
INSERT INTO bairro (bairro_nome,id_cidade)
  VALUES ("Vila Nova","4");
  
INSERT INTO bairro (bairro_nome,id_cidade)
  VALUES ("Sabará","3");

  
  -- Tabela rua

INSERT INTO rua (rua_nome,cep_rua,id_bairro)
  VALUES ("Sete de Setembro","84.500-442","2");
  
INSERT INTO rua (rua_nome,cep_rua,id_bairro)
  VALUES ("Dos Operários","84.501-657","4");
  
INSERT INTO rua (rua_nome,cep_rua,id_bairro)
  VALUES ("XV de Novembro","84.500-357","3");
  
INSERT INTO rua (rua_nome,cep_rua,id_bairro)
  VALUES ("Br 153","84.500-286","1");
  

  -- Tabela cliente
  
INSERT INTO cliente (nome,cpf,email,celular,cep,num_residencia,id_rua)
  VALUES ("Antonio Silva","123.456.789-01","silva@ig.com.br","(41) 9 8414-3241","84.500-286","102","4");

INSERT INTO cliente (nome,cpf,email,celular,cep,num_residencia,id_rua)
  VALUES ("Melissa Xavier","098.765.432-10","mxavier@uol.com.br","(47) 9 9314-7342","84.500-442","375","1");

INSERT INTO cliente (nome,cpf,email,celular,cep,num_residencia,id_rua)
  VALUES ("Alfredo Branco","624.769.734-46","branfredo@gmail.com","(11) 9 8455-1084","84.501-657","936","2");

INSERT INTO cliente (nome,cpf,email,celular,cep,num_residencia,id_rua)
  VALUES ("Higor Camargo","044.388.833-98","dr_higor@hotmail.com","(63) 9 3300-8643","84.500-357","1.653","3");


  -- Tabela categoria

INSERT INTO categoria (categoria_nome)
  VALUES ("Mesa");

INSERT INTO categoria (categoria_nome)
  VALUES ("Porta Doce");

INSERT INTO categoria (categoria_nome)
  VALUES ("Painel");

INSERT INTO categoria (categoria_nome)
  VALUES ("Tapete");

INSERT INTO categoria (categoria_nome)
  VALUES ("Vaso");

  -- Tabela cor

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("","Estampado");

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("#000000","Preto");

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("#FFFFFF","Branco");

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("#FF0000","Vermelho");

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("#FFC2FF","Lilás");

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("#BF95BF","Rosa");

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("#0678BF","Azul");

INSERT INTO cor (cod_rgb_hexa_cmyk,cor_nome)
  VALUES ("#09B300","Verde");

  -- Tabela tema

INSERT INTO tema (tema_nome)
  VALUES ("Neutro");

INSERT INTO tema (tema_nome)
  VALUES ("Dinossauro");

INSERT INTO tema (tema_nome)
  VALUES ("Patrulha Canina");

INSERT INTO tema (tema_nome)
  VALUES ("Dourado");

INSERT INTO tema (tema_nome)
  VALUES ("Stitch");


  -- Tabela produto

INSERT INTO produto (descricao,tamanho,quantidade,custo,valor,id_categoria,id_tema,id_cor)
  VALUES ("Painel Redondo","1.20m","2","40.00","20.00","3","4","1");

INSERT INTO produto (descricao,tamanho,quantidade,custo,valor,id_categoria,id_tema,id_cor)
  VALUES ("Porta Doces Redondo","0.45cm","15","60.00","30.00","2","1","7");

INSERT INTO produto (descricao,tamanho,quantidade,custo,valor,id_categoria,id_tema,id_cor)
  VALUES ("Mesa Branca","1.40m x 0.90m","2","485.00","230.00","1","1","3");

INSERT INTO produto (descricao,tamanho,quantidade,custo,valor,id_categoria,id_tema,id_cor)
  VALUES ("Vaso","0.40m","22","79.50","43.00","5","1","2");

INSERT INTO produto (descricao,tamanho,quantidade,custo,valor,id_categoria,id_tema,id_cor)
  VALUES ("Grama Sintética","4.00m x 3.00m","2","438.00","120>00","4","1","8");


  -- Tabela orcamento

INSERT INTO orcamento (data_emissao,data_evento,hora_evento,total,local_evento,tipo_evento,tema,validade,aprovacao)
  VALUES ("2025-05-20","2025-10-24","15:00","200.00","Rancho do Lago","Aniversário","Stitch","15 dias","sim");


   -- Tabela itens_orcamento

INSERT INTO itens_orcamento (quantidade,subtotal,id_produto,id_orcamento)
  VALUES ("1","120.00","5","1");

INSERT INTO itens_orcamento (quantidade,subtotal,id_produto,id_orcamento)
  VALUES ("1","20.00","1","1");

INSERT INTO itens_orcamento (quantidade,subtotal,id_produto,id_orcamento)
  VALUES ("1","60.00","2","1");




  -- Tabela agendamento

INSERT INTO agendamento (data_emissao,data_evento,hora_evento,total,local_evento,tipo_evento,tema,id_cliente)
  VALUES ("2025-05-20","2025-10-24","15:00","200.00","Rancho do Lago","Aniversário","Stitch","2");


   -- Tabela itens_agendamento

INSERT INTO itens_agendamento (quantidade,subtotal,id_produto,id_agendamento)
  VALUES ("1","120.00","5","1");

INSERT INTO itens_agendamento (quantidade,subtotal,id_produto,id_agendamento)
  VALUES ("1","20.00","1","1");

INSERT INTO itens_agendamento (quantidade,subtotal,id_produto,id_agendamento)
  VALUES ("1","60.00","2","1");


  -- Tabela receber

INSERT INTO receber (data_emissao,valor_total,id_agendamento)
  VALUES ("2025-05-20","200.00","1");


  -- Tabela parcelamento

INSERT INTO parcelamento (tipo_pagamento,data_pagamento,valor,vencimento,parcela,id_receber)
  VALUES ("Cartão","2025-05-20","50.00","2025-05-20","1-4","1");

INSERT INTO parcelamento (tipo_pagamento,data_pagamento,valor,vencimento,parcela,id_receber)
  VALUES ("Cartão","0000-00-00","50.00","2025-06-20","2-4","1");

INSERT INTO parcelamento (tipo_pagamento,data_pagamento,valor,vencimento,parcela,id_receber)
  VALUES ("Cartão","0000-00-00","50.00","2025-07-20","3-4","1");

INSERT INTO parcelamento (tipo_pagamento,data_pagamento,valor,vencimento,parcela,id_receber)
  VALUES ("Cartão","0000-00-00","50.00","2025-08-20","4-4","1");
