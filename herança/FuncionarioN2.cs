namespace herança;
class FuncionarioN2:Funcionario

{  
   

    
public override double Participacao(){
    return base.Participacao()* 0.02;
 }
}