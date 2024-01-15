const typeFilm = ['movies','episode','series'];
const menuType = document.querySelector('.menu-type');
let Type =' ';
let selectedType = 'Type film';
typeFilm.forEach((type) => {
    Type += `<li><a class="dropdown-item list-menu-type" href="#" data-stype="${type}">${type}</a></li>`;
})
    menuType.innerHTML = Type ;

menuType.addEventListener('click',async function(type) {
    if (type.target.classList.contains('list-menu-type')) {
        const selectType = document.querySelector('.select-type');
        const searchFilm = document.querySelector('.search-film');

        searchFilm.value=''

        selectedType = type.target.dataset.stype;
        selectType.innerHTML = selectedType;
        const getType =await getTypeFilm(selectedType,1);
        updateUItype(getType)
        curentPage = 1
    } 
})

const Searchbtn = document.querySelector('.btn-search-film');
Searchbtn.addEventListener('click', async function(){
    try {
        const searchFilm = document.querySelector('.search-film');
        const movie = await getMovies(searchFilm.value);
        updateUI(movie);
        selectedType = 'Type film';
        const selectType = document.querySelector('.select-type');
        selectType.innerHTML = selectedType;
        curentPage = 1

    } catch (error) {
        // error_film_notFound(error)
        error_film_notFound(error)
        // console.log(error);
    }

})

let curentPage = 1;

//event binding
document.addEventListener('click',async function(e){
    if(e.target.classList.contains('modal-detail-btn')) {
        const detailMovies = await getDetailmovies(e.target.dataset.imdbid);
       updateUiDetails(detailMovies)
    } 

    // console.log(e.target);


    //next and prev page film

    if(e.target.classList.contains('page-number')) {
        const pagenumber = e.target.textContent
        // console.log(pagenumber);
        curentPage = pagenumber
            const getType =await getTypeFilm(selectedType,curentPage);
            updateUItype(getType)
    }

    if (e.target.classList.contains('nextFilm')) {
        // e.addEventListener('click', async function () {
            curentPage += 1
            const getType =await getTypeFilm(selectedType,curentPage);
            updateUItype(getType)      
    }
    if (e.target.classList.contains('prevFilm')  && curentPage > 1) {
        // e.addEventListener('click', async function () {
            curentPage -= 1
            const getType =await getTypeFilm(selectedType,curentPage);
            updateUItype(getType)      
    }
    

})

function getMovies(keyword ) {
   return fetch(`http://www.omdbapi.com/?apikey=1505c578&s=${keyword}`   )
    .then(response => {
        if(!response.ok) {
            throw new Error(response.Status)
        }
      return response.json()
    })
    .then(result => {
        if (result.Response === 'False') {
            throw new Error(result.Error)
        }
    return result.Search
    })
    
    // .catch(err=> console.log(err))
}

function updateUI(film) {
    const movieContainer = document.querySelector('.movie-container');
    let cards = ' ';
        film.forEach(m => {
                cards += showCards(m);
        });
        /*for (let i = 0; i < 5 && i < film.length; i++) {  //hanya 5
            cards += showCards(film[i])
        }*/ 
    movieContainer.innerHTML = cards;
    
}


function getDetailmovies(imdbIDFilm) {
    return fetch('http://www.omdbapi.com/?apikey=1505c578&i=' + imdbIDFilm)
    .then((response) => response.json())
    .then(result => result)
    .catch((err) => console.log(err))
}

function updateUiDetails(detail) {
    const detailContainer = document.querySelector('.detail-container');
    const detailfilm = showDetails(detail);
    detailContainer.innerHTML = detailfilm;
}

function updateUItype(film) {
    const movieContainer = document.querySelector('.movie-container');
    const nextPage = document.querySelector('.next-page');
    let cards = ' ';
        film.forEach(m => {
                cards += showCards(m);
        });
        /*for (let i = 0; i < 5 && i < film.length; i++) {  //hanya 5
            cards += showCards(film[i])
        }*/ 
    movieContainer.innerHTML = cards;
    nextPage.innerHTML = showPagginaton();
}

function getTypeFilm (type,data){
    return fetch(`http://www.omdbapi.com/?apikey=1505c578&s=${type}&page=${data}`)
    .then((response) => response.json())
    .then((result) => result.Search)
    .catch((err) => console.log(err))
}

function showCards(m) {
    return `<div class="col-md-4 my-5">
             <div class="card ">
                 <img src="${m.Poster}" class="card-img-top" >
                 <div class="card-body">
                   <h5 class="card-title">${m.Title}</h5>
                   <h6 class="card-subtitle mb-2 text-body-secondary">${m.Year}</h6>
                   <a href="#" class="btn btn-primary modal-detail-btn" data-bs-toggle="modal" data-bs-target="#movieDetailModal" data-imdbid="${m.imdbID}">Show details</a>
                 </div>
             </div>
         </div>`;
 }
 
 function showDetails(result) {
     return `<div class="container-fluid">
     <div class="row">
         <div class="col-md-3">
             <img src="${result.Poster}" alt="" class="img-fluid">
         </div>
         <div class="col-md">
             <ul class="list-group list-group-flush">
                 <li class="list-group-item"><h4> ${result.Title} (${result.Year})</h4></li>
                 <li class="list-group-item "><strong > Director : </strong> ${result.Director}</li>
                 <li class="list-group-item"><strong> Actor : </strong> ${result.Actors}</li>
                 <li class="list-group-item"><strong> Writer : </strong> ${result.Writer}</li>
                 <li class="list-group-item"><strong> Genre : </strong> ${result.Genre}</li>
                 <li class="list-group-item"><strong> Awards : </strong> ${result.Awards}</li>
             </ul>
         </div>
         </div>
     </div>`;
 }

 function showPagginaton(params) {
    return `
    <nav aria-label="...">
      <ul class="pagination pagination-lg justify-content-center">
        <li class="page-item "><a class="page-link prevFilm" href="#" tabindex="-1" aria-disabled="true">Previous</a></li>
        <li class="page-item"><a class="page-link page-number" href="#">1</a></li>
        <li class="page-item" aria-current="page"><a class="page-link page-number" href="#">2</a></li>
        <li class="page-item"><a class="page-link page-number" href="#">3</a></li>
        <li class="page-item"><a class="page-link page-number" href="#">4</a></li>
        <li class="page-item"><a class="page-link page-number" href="#">5</a></li>
        <li class="page-item "><a class="page-link nextFilm" href="#">Next</a></li>
      </ul>
    </nav>`
 }

 function error_film_notFound(err) {
    return Swal.fire({
        icon: "error",
        title: "😹Oops...",
        text: `Film tidak di temukan 😥`
      });   
 }