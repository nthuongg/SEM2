@extends('layouts.app-master')

@section('content')
    <div class="bg-light p-5 rounded">
        @auth
        <div class="container mt-5">

        <h1 class="text-primary mt-3 mb-4 text-center"><b>Laravel 9 Crud Application</b></h1>

        </div>
        @endauth

        @guest
        <h1>Homepage</h1>
        <p class="lead">Your viewing the home page. Please login to view the restricted data.</p>
        @endguest
    </div>
@endsection
