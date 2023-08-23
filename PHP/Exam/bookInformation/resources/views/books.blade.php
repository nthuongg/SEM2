@extends('master')

@section('content')
    <h2>Search results for "{{ $query }}"</h2>

    @if(count($books) > 0)
        <ul>
            @foreach($books as $book)
                <li>{{ $book->title }}</li>
                <li>{{ $book->ISBN }}</li>
                <li>{{ $book->pub_year }}</li>
                <li>{{ $book->available== 1 ? 'This book is currently in stock' : 'This book is currently out of stock' }}</li>
            @endforeach
        </ul>
    @else
        <p>No results found.</p>
    @endif
@endsection

