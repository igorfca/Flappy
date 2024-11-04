/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.gerenciabanco;

import java.util.Scanner;
/**
 *
 * @author Igor
 */
class ContaBancaria{
    private String nome;
    private String sobrenome;
    private String cpf;
    private double saldo;
    
    public ContaBancaria (String nome, String sobrenome, String cpf){
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.cpf = cpf;
        this.saldo = 0.0;
    }
    
    public double consultarSaldo(){
        return saldo;
    }
    
    public void depositar(double valor){
        if (valor > 0){
            saldo += valor;
            System.out.println("Depósito de: R$" + valor + "Saldo de: R$" + saldo);
        } else{
            System.out.println("Valor inválido");
        }
    }
    
    public void sacar(double valor){
        if (valor > 0 && saldo >= valor){
            saldo -= valor;
            System.out.println("Saque de R$" + valor +" realizado");
        } else{
            System.out.println("Saldo insuficiente");
        }
    }
    
    public void exibirInformacoes(){
        System.out.println("Nome: " + nome + " " + sobrenome);
        System.out.println("CPF:" + cpf);
        System.out.println("Saldo: R$:" + saldo);
    }
}

public class GerenciaBanco {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Solicitação dos dados do usuário
        System.out.print("Digite seu nome: ");
        String nome = scanner.nextLine();
        System.out.print("Digite seu sobrenome: ");
        String sobrenome = scanner.nextLine();
        String cpf;
        do{
            System.out.print("Digite seu CPF: ");
            cpf = scanner.nextLine();
            if(cpf.length()!= 11){
            System.out.println("CPF inválido. Deve ter 11 dígitos");}
        } while (cpf.length() != 11);
        
        ContaBancaria conta = new ContaBancaria(nome, sobrenome, cpf);

        // Exibição do menu
        int opcao;
        do {
            System.out.println("\nEscolha uma opção:");
            System.out.println("1 - Consultar Saldo");
            System.out.println("2 - Depósito");
            System.out.println("3 - Saque");
            System.out.println("4 - Exibir Informações do Usuário");
            System.out.println("0 - Sair");
            System.out.print("Opção: ");
            opcao = scanner.nextInt();

            switch (opcao) {
                case 1:
                    System.out.println("Seu saldo atual é: R$ " + conta.consultarSaldo());
                    break;
                case 2:
                    System.out.print("Digite o valor para depósito: ");
                    double valorDeposito = scanner.nextDouble();
                    conta.depositar(valorDeposito);
                    break;
                case 3:
                    System.out.print("Digite o valor para saque: ");
                    double valorSaque = scanner.nextDouble();
                    conta.sacar(valorSaque);
                    break;
                case 4:
                    conta.exibirInformacoes();
                    break;
                case 0:
                    System.out.println("Obrigado por utilizar o Pelados banco, falo!");
                    break;
                default:
                    System.out.println("Opção inválida. Tente novamente.");
            }
        } while (opcao != 0);

        scanner.close();
    }
}