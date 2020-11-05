import axios from "axios"
export const contacts = []
const urlBase = "http://localhost:3020"
export const getContacts = () => {
    // return new Promise((resolve, reject) => {
    //     setTimeout(() => {
    //         resolve(annonces)
    //     },3000)
    // })
    return axios.get(`${urlBase}/contacts`)

}
let compteurContact = 1



export const ajouterContact = (contact) => {
    // const tmpAnnonce = {
    //     ...annonce,
    //     id : compteurAnnonce
    // }
    // annonces.push(tmpAnnonce)
    // compteurAnnonce++
    return axios.post(`${urlBase}/contact`, {...contact})
}

export const search = (filter) => {
    // return new Promise((resolve, reject) => {
    //     const tmpAnnonces = annonces.filter(a => a.titre.includes(filtre) || a.description.includes(filtre))
    //     setTimeout(() => {
    //         resolve(tmpAnnonces)
    //     }, 3000)
    // })

    return axios.get(`${urlBase}/contacts/${filter}`)
}

export const getAnnonceById = (id) => {
    //return annonces.find(a => a.id == id)
    return axios.get(`${urlBase}/contact/${id}`)
}

const users = [
    {login : 'formation', password : '123456'}
]
export let isLogged = false
export const login = (login, password) => {
    const u = users.find(l => l.login == login && l.password == password)
 
    return u != undefined
}
export const changeIsLogged = (log) => {
    isLogged = log
}