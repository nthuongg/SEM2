<?php $__env->startSection('content'); ?>
    <h2>Search results for "<?php echo e($query); ?>"</h2>

    <?php if(count($books) > 0): ?>
        <ul>
            <?php $__currentLoopData = $books; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $book): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
                <li><?php echo e($book->title); ?></li>
                <li><?php echo e($book->ISBN); ?></li>
                <li><?php echo e($book->pub_year); ?></li>
                <li><?php echo e($book->available== 1 ? 'This book is currently in stock' : 'This book is currently out of stock'); ?></li>
            <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
        </ul>
    <?php else: ?>
        <p>No results found.</p>
    <?php endif; ?>
<?php $__env->stopSection(); ?>


<?php echo $__env->make('master', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH D:\SEM2\PHP\Exam\bookInformation\resources\views/books.blade.php ENDPATH**/ ?>