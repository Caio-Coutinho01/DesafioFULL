
import { Validacoes } from './../../assets/validators';
import { Component, OnInit, NgModule } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { UserDataService } from '../_data-services/user.data-service';
import * as moment from 'moment';


declare function TableFilter(): any;
declare function DisabledButton(): any;

@Component({
    selector: 'app-users',
    templateUrl: './users.component.html',
    styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
    public usersForm: FormGroup;
    public parcelForm: FormGroup;
    displayedColumns = ['numParcel', 'vlrParcel', 'fees', 'fine', 'dateDue'];

    users: any[] = [];
    user: any = {};
    parcel: any[] = [];
    showlist: boolean = true;
    desabilitaBotao: boolean = false;
    tbParcel: boolean = false;

    constructor(private userDataService: UserDataService, private fb: FormBuilder) { }

    ngOnInit() {

        this.usersForm = this.fb.group({
            id: [],
            titleNumber: ['', Validators.required],
            name: ['', Validators.required],
            cpf: new FormControl('', [
                Validators.required,
                Validators.pattern(/^(\d{3}\.){2}\d{3}\-\d{2}$/),
                Validators.minLength(14),
                Validators.maxLength(14)]),
        });
        this.parcelForm = this.fb.group({
            id: [],
            fees: ['', Validators.required],
            fine: ['', Validators.required],
            dateDue: ['', Validators.required],
            // dtEmissao : [],
            vlrParcel: ['', Validators.required],
            numParcel: ['', Validators.required],
            valTotal: [''],
        })

        this.get();
    }

    get() {
        this.userDataService.get().subscribe((data: any[]) => {
            this.users = data;
            TableFilter()
        }, error => {
            console.log(error);
            alert('erro interno do sistema');
        })
    }

    save() {
        var arr = JSON.parse(localStorage.getItem("parcels"));
        if (arr != null || arr != "") {
            this.post();
            this.clear();
            this.showlist=false;
        }else{
            alert("generate a parcel!")
        }
    }

    openDetails(user) {
debugger;
        this.desabilitaBotao = true;
        this.showlist = false;
        this.getParcels(user.id);
        this.user = user;
    }


    post() {
        var arr = JSON.parse(localStorage.getItem("parcels"));
        arr.push(this.usersForm.value)
        this.userDataService.post(JSON.stringify(arr)).subscribe(data => {
            if (data) {
                alert('Usuario cadastrado com sucesso!');
                this.get();
                this.user = {}
            } else {
                alert('Erro ao cadastrar usuario')
            }
        }, error => {
            console.log(error);
            alert('Erro interno do sistema');
        })
    }

    gerarParcelaTemp() {
        if (this.parcelForm.valid) {
            var arr = []
            let NewDate: moment.Moment = moment.utc(this.parcelForm.value.DateDue).local()
            this.parcelForm.value.DateDue = NewDate.format("DD/MM/YYYY") + "T" + "00:00:00"
            var stored = JSON.parse(localStorage.getItem("parcels"));
            if (stored != null) {

                arr = stored
                arr.push(this.parcelForm.value)
                this.tbParcel = true;
                this.parcel = arr
                this.parcelForm.reset();
                localStorage.setItem("parcels", JSON.stringify(this.parcel));
            } else {
                this.tbParcel = true;
                this.parcel = [this.parcelForm.value]
                this.parcelForm.reset();
                localStorage.setItem("parcels", JSON.stringify(this.parcel));
            }
        } else {
            alert("Campos obrigatorios não preenchidos")
        }
    }

    getParcels(params) {

        this.userDataService.getParcels(params).subscribe((data: []) => {
            debugger;
            this.parcel = data;
            this.tbParcel = true;
            TableFilter()
        }, error => {
            console.log(error);
            alert('erro interno do sistema');
        })
    }
    addUser() {
        this.get();
       if(this.showlist == true){
           this.showlist = false
           
       }else{
           this.showlist = true;
       }
       
       this.clear();
      
    }

    clear(){
        this.parcelForm.reset();
        this.usersForm.reset();
        this.parcel = [];
        this.tbParcel = false;
        this.desabilitaBotao = false;
        localStorage.removeItem('parcels');
    }
    // put() {

    //     this.userDataService.put(this.user).subscribe(data => {
    //         if (data) {
    //             alert('Usuario atualizado com sucesso!');
    //             this.get();
    //             this.user = {}
    //         } else {
    //             alert('Erro ao cadastrar usuario')
    //         }
    //     }, error => {
    //         console.log(error);
    //         alert('Erro interno do sistema');
    //     })
    // }

    // delete(user) {
    //     this.userDataService.delete(user.id).subscribe(data => {
    //         if (data) {
    //             alert('Usuario excluido com sucesso!');
    //             this.get();
    //             this.user = {}
    //         } else {
    //             alert('Erro ao excluir usuario!');
    //         }
    //     }, error => {
    //         console.log(error);
    //         alert('erro interno do sistema');
    //     })
    // }


}

